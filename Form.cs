using System.Drawing.Drawing2D;
using System.Resources;
using System.Security.Principal;
using lab3.Properties;
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.AxHost;

namespace lab3
{
    public partial class Application : Form
    {
        private DirectBitmap image;
        private ColorHistogram histogram;

        private DirectBitmap filterBuffer;
        private DirectBitmap outputBuffer;

        private bool isDrawing;
        private PaintBrush brush;
        private Filter filter;

        private Polygon polygon;
        private Point mousePos;

        private bool ignoreFilterUpdate = false;

        private enum FilterApplyModes
        {
            Brush, Polygon
        };
        private FilterApplyModes filterMode;

        public Application()
        {
            InitializeComponent();

            brush = new PaintBrush(brushRadiusSlider.Value);
            filter = Filter.Identity;
            polygon = new Polygon();

            canvas.SizeMode = PictureBoxSizeMode.StretchImage;

            filterBuffer = new DirectBitmap(canvas.Width + 1, canvas.Height + 1);
            outputBuffer = new DirectBitmap(canvas.Width + 1, canvas.Height + 1);

            SetImage((Image)Resources.ResourceManager.GetObject("fale")!);

            filterMode = FilterApplyModes.Brush;
            brushRadioButton.Checked = true;

            filterTypeComboBox.SelectedItem = "Identity";

            FillOutputBuffer();
        }


        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chooseFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tif";
            chooseFileDialog.FilterIndex = 1;

            if (chooseFileDialog.ShowDialog() == DialogResult.OK)
            {
                SetImage(Image.FromFile(chooseFileDialog.FileName));
            }
        }

        private void SetImage(Image img)
        {
            image = new DirectBitmap(img, canvas.Width + 1, canvas.Height + 1);

            histogram = new ColorHistogram(image);

            UpdateImage();
        }

        private void FillOutputBuffer()
        {
            //for (int i = 0; i < canvas.Width; ++i)
            Parallel.For(0, canvas.Width, i =>
            {
                //for (int j = 0; j < canvas.Height; ++j)
                Parallel.For(0, canvas.Height, j =>
                {
                    Color col;
                    if (filterBuffer.IsPixelColored(i, j))
                        col = filter.Apply(ref image, i, j);
                    else
                        col = image.GetPixel(i, j);

                    outputBuffer.SetPixel(i, j, col);
                });
            });
        }

        private void redHistogramPictureBox_Paint(object sender, PaintEventArgs e)
        {
            histogram?.DrawHistogram(e.Graphics,
                    ColorHistogram.HistogramColor.RED,
                    redHistogramPictureBox.Width,
                    redHistogramPictureBox.Height);
        }

        private void greenHistogramPictureBox_Paint(object sender, PaintEventArgs e)
        {
            histogram?.DrawHistogram(e.Graphics,
                    ColorHistogram.HistogramColor.GREEN,
                    greenHistogramPictureBox.Width,
                    greenHistogramPictureBox.Height);
        }

        private void blueHistogramPictureBox_Paint(object sender, PaintEventArgs e)
        {
            histogram?.DrawHistogram(e.Graphics,
                    ColorHistogram.HistogramColor.BLUE,
                    blueHistogramPictureBox.Width,
                    blueHistogramPictureBox.Height);
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.DrawImage(outputBuffer.Bitmap, 0, 0);

            if (filterMode == FilterApplyModes.Brush)
            {
                Pen dashedPen = new Pen(new SolidBrush(Color.Bisque));
                dashedPen.DashStyle = DashStyle.Dash;
                g.DrawEllipse(dashedPen,
                    brush.Position.X - brush.Radius,
                    brush.Position.Y - brush.Radius,
                    2 * brush.Radius, 2 * brush.Radius);
            }
            else if (filterMode == FilterApplyModes.Polygon)
            {
                polygon.DrawUnfinishedPolygon(g, mousePos);
            }
        }


        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            UpdateImage();
        }

        private void UpdateImage(bool refreshHistograms = true)
        {
            FillOutputBuffer();
            if (refreshHistograms)
            {
                histogram.CalculateHistogram(outputBuffer);
                histogramGroupBox.Refresh();
            }
            canvas.Refresh();
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            mousePos = e.Location;
            brush.Position = mousePos;
            if (filterMode == FilterApplyModes.Brush && isDrawing)
            {
                brush.PaintOnBitmap(filterBuffer, eraseCheckBox.Checked);
                UpdateImage();
            }

            canvas.Refresh();
        }

        private void brushRadiusSlider_ValueChanged(object sender, EventArgs e)
        {
            brush.Radius = brushRadiusSlider.Value;
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (filterMode == FilterApplyModes.Polygon)
            {
                if (polygon.vertices.Count > 0)
                {
                    Point initialPoint = polygon.vertices.First();
                    if (initialPoint.IsCloseToPoint(e.Location))
                    {
                        using (var g = Graphics.FromImage(filterBuffer.Bitmap))
                            polygon.FillPolygon(g, eraseCheckBox.Checked);

                        UpdateImage();
                        polygon = new Polygon();

                        return;
                    }
                }

                polygon.vertices.Add(e.Location);
            }
        }

        private void brushRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (brushRadioButton.Checked)
            {
                filterMode = FilterApplyModes.Brush;
                brushRadiusSlider.Enabled = true;
            }
        }

        private void polygonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (polygonRadioButton.Checked)
            {
                filterMode = FilterApplyModes.Polygon;
                brushRadiusSlider.Enabled = false;
                polygon = new Polygon();
            }
        }


        private void filterTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (filterTypeComboBox.SelectedItem)
            {
            case "Identity":
                filter = Filter.Identity;
                autoDivisorCheckBox.Checked = true;
                break;
            case "Edge detection":
                filter = Filter.EdgeDetection;
                break;
            case "Sharpen":
                filter = Filter.Sharpen;
                autoDivisorCheckBox.Checked = true;
                break;
            case "Box blur":
                filter = Filter.BoxBlur;
                autoDivisorCheckBox.Checked = true;
                break;
            case "Gaussian blur":
                filter = Filter.GaussBlur;
                autoDivisorCheckBox.Checked = true;
                break;
            case "Sculpt SE":
                filter = Filter.SculptSE;
                autoDivisorCheckBox.Checked = true;
                break;
            }


            ignoreFilterUpdate = true;
            divisorInput.Value = (decimal)filter.Divisor;
            offsetSlider.Value = filter.Offset;
            m00Input.Value = (decimal)filter.Matrix[0, 0];
            m01Input.Value = (decimal)filter.Matrix[0, 1];
            m02Input.Value = (decimal)filter.Matrix[0, 2];
            m10Input.Value = (decimal)filter.Matrix[1, 0];
            m11Input.Value = (decimal)filter.Matrix[1, 1];
            m12Input.Value = (decimal)filter.Matrix[1, 2];
            m20Input.Value = (decimal)filter.Matrix[2, 0];
            m21Input.Value = (decimal)filter.Matrix[2, 1];
            m22Input.Value = (decimal)filter.Matrix[2, 2];
            ignoreFilterUpdate = false;

            UpdateImage();
        }

        private void autoDivisorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            divisorInput.Enabled = !autoDivisorCheckBox.Checked;
            if (autoDivisorCheckBox.Checked)
            {
                filter.CalculateDivisor();
                ignoreFilterUpdate = true;
                divisorInput.Value = (decimal)filter.Divisor;
                ignoreFilterUpdate = false;
            }
            else
            {
                filter.Divisor = (float)divisorInput.Value;
            }
            UpdateImage();
        }

        private void divisorInput_ValueChanged(object sender, EventArgs e)
        {
            if (ignoreFilterUpdate)
                return;

            filter.Divisor = (float)divisorInput.Value;
            filterTypeComboBox.SelectedItem = "Custom";
            UpdateImage();
        }

        private void matrixInputChanged(int i, int j, float value)
        {
            if (ignoreFilterUpdate)
                return;

            filter.Matrix[i, j] = value;
            filterTypeComboBox.SelectedItem = "Custom";

            if (autoDivisorCheckBox.Checked)
            { 
                filter.CalculateDivisor();
                ignoreFilterUpdate = true;
                divisorInput.Value = (decimal)filter.Divisor;
                ignoreFilterUpdate = false;
            }
            UpdateImage();
        }

        private void m00Input_ValueChanged(object sender, EventArgs e)
        {
            matrixInputChanged(0, 0, (float)m00Input.Value);
        }

        private void m01Input_ValueChanged(object sender, EventArgs e)
        {
            matrixInputChanged(0, 1, (float)m01Input.Value);
        }

        private void m02Input_ValueChanged(object sender, EventArgs e)
        {
            matrixInputChanged(0, 2, (float)m02Input.Value);
        }

        private void m10Input_ValueChanged(object sender, EventArgs e)
        {
            matrixInputChanged(1, 0, (float)m10Input.Value);
        }

        private void m11Input_ValueChanged(object sender, EventArgs e)
        {
            matrixInputChanged(1, 1, (float)m11Input.Value);
        }

        private void m12Input_ValueChanged(object sender, EventArgs e)
        {
            matrixInputChanged(1, 2, (float)m12Input.Value);
        }

        private void m20Input_ValueChanged(object sender, EventArgs e)
        {
            matrixInputChanged(2, 0, (float)m20Input.Value);
        }

        private void m21Input_ValueChanged(object sender, EventArgs e)
        {
            matrixInputChanged(2, 1, (float)m21Input.Value);
        }

        private void m22Input_ValueChanged(object sender, EventArgs e)
        {
            matrixInputChanged(2, 2, (float)m22Input.Value);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            filterBuffer.Clear();
            UpdateImage();
        }

        private void wholeImageButton_Click(object sender, EventArgs e)
        {
            filterBuffer.SetFilled();
            UpdateImage();
        }

        private void offsetSlider_Scroll(object sender, EventArgs e)
        {
            if (ignoreFilterUpdate)
                return;

            filter.Offset = offsetSlider.Value;
            filterTypeComboBox.SelectedItem = "Custom";
            UpdateImage();
        }


        private void dogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetImage((Image)Resources.ResourceManager.GetObject("original")!);
        }

        private void pKiNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetImage((Image)Resources.ResourceManager.GetObject("pkin")!);
        }

        private void wavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetImage((Image)Resources.ResourceManager.GetObject("fale")!);
        }

        private void mountainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetImage((Image)Resources.ResourceManager.GetObject("gora")!);
        }

        private void flowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetImage((Image)Resources.ResourceManager.GetObject("maki")!);
        }
    }
}
