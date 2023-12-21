namespace lab3
{
    public partial class Application : Form
    {
        private DirectBitmap image;
        private ColorHistogram histogram;

        public Application()
        {
            InitializeComponent();

            image = new DirectBitmap(canvas.Width, canvas.Height);
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
            canvas.Image = img;

            histogram = new ColorHistogram(image);

            histogramGroupBox.Refresh();
        }

        private void redHistogramPictureBox_Click(object sender, EventArgs e)
        {
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
    }
}
