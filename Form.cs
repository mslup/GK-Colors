using System.Drawing.Drawing2D;
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

        private enum FilterApplyModes
        {
            Brush, Polygon
        };
        private FilterApplyModes filterMode;

        public Application()
        {
            InitializeComponent();

            brush = new PaintBrush(brushRadiusSlider.Value);
            filter = new Filter();
            polygon = new Polygon();
            filterMode = FilterApplyModes.Polygon;

            canvas.SizeMode = PictureBoxSizeMode.StretchImage;
            SetImage(Image.FromFile("C:\\Users\\marci\\Pictures\\original.jpg"));

            filterBuffer = new DirectBitmap(canvas.Width + 1, canvas.Height + 1);
            outputBuffer = new DirectBitmap(canvas.Width + 1, canvas.Height + 1);

            FillOutputBuffer();
        }


        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

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

            histogramGroupBox.Refresh();
            canvas.Refresh();
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
                // todo: move this outside
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
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            mousePos = e.Location;
            brush.Position = mousePos;
            if (filterMode == FilterApplyModes.Brush && isDrawing)
            {
                brush.PaintOnBitmap(filterBuffer);

                FillOutputBuffer();

                histogram.CalculateHistogram(outputBuffer);
                histogramGroupBox.Refresh();
            }

            canvas.Refresh();
        }

        private void brushRadiusSlider_ValueChanged(object sender, EventArgs e)
        {
            brush.Radius = brushRadiusSlider.Value;
        }

        private void canvas_Click(object sender, EventArgs e)
        {

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
                            polygon.FillPolygon(g);

                        FillOutputBuffer();
                        polygon = new Polygon();

                        canvas.Refresh();

                        return;
                    }
                }

                polygon.vertices.Add(e.Location);
            }
        }
    }
}
