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

        public Application()
        {
            InitializeComponent();

            filterBuffer = new DirectBitmap(canvas.Width + 1, canvas.Height + 1);
            outputBuffer = new DirectBitmap(canvas.Width + 1, canvas.Height + 1);
            brush = new PaintBrush();

            canvas.SizeMode = PictureBoxSizeMode.StretchImage;
            SetImage(Image.FromFile("C:\\Users\\marci\\Pictures\\original.jpg"));
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


        private void redHistogramPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (histogram != null)
                histogram.DrawHistogram(e.Graphics,
                    ColorHistogram.HistogramColor.RED,
                    redHistogramPictureBox.Width,
                    redHistogramPictureBox.Height);
        }

        private void greenHistogramPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (histogram != null)
                histogram.DrawHistogram(e.Graphics,
                    ColorHistogram.HistogramColor.GREEN,
                    greenHistogramPictureBox.Width,
                    greenHistogramPictureBox.Height);
        }

        private void blueHistogramPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (histogram != null)
                histogram.DrawHistogram(e.Graphics,
                    ColorHistogram.HistogramColor.BLUE,
                    blueHistogramPictureBox.Width,
                    blueHistogramPictureBox.Height);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            for (int i = 0; i < canvas.Width; ++i)
            {
                for (int j = 0; j < canvas.Height; ++j)
                {
                    Color col;
                    if (filterBuffer.IsPixelColored(i, j))
                        col = Color.Black;
                    else
                        col = image.GetPixel(i, j);

                    outputBuffer.SetPixel(i, j, col);
                }
            }

            g.DrawImage(outputBuffer.Bitmap, 0, 0);
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
            brush.Position = e.Location;
            if (isDrawing)
            {
                //filterBuffer.SetPixelColored(e.X, e.Y);
                brush.PaintOnBitmap(filterBuffer);
            }
            canvas.Refresh();
        }
    }
}
