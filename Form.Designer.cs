namespace lab3
{
    partial class Application
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            canvas = new PictureBox();
            histogramGroupBox = new GroupBox();
            blueHistogramPictureBox = new PictureBox();
            greenHistogramPictureBox = new PictureBox();
            redHistogramPictureBox = new PictureBox();
            chooseFileDialog = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            chooseToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            histogramGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)blueHistogramPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenHistogramPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redHistogramPictureBox).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(canvas);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Panel2.Controls.Add(histogramGroupBox);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1059, 426);
            splitContainer1.SplitterDistance = 432;
            splitContainer1.TabIndex = 0;
            // 
            // canvas
            // 
            canvas.Dock = DockStyle.Fill;
            canvas.Location = new Point(0, 0);
            canvas.Name = "canvas";
            canvas.Size = new Size(432, 426);
            canvas.TabIndex = 0;
            canvas.TabStop = false;
            // 
            // histogramGroupBox
            // 
            histogramGroupBox.Controls.Add(blueHistogramPictureBox);
            histogramGroupBox.Controls.Add(greenHistogramPictureBox);
            histogramGroupBox.Controls.Add(redHistogramPictureBox);
            histogramGroupBox.Dock = DockStyle.Left;
            histogramGroupBox.Location = new Point(0, 0);
            histogramGroupBox.Name = "histogramGroupBox";
            histogramGroupBox.Size = new Size(262, 426);
            histogramGroupBox.TabIndex = 0;
            histogramGroupBox.TabStop = false;
            histogramGroupBox.Text = "Histograms";
            // 
            // blueHistogramPictureBox
            // 
            blueHistogramPictureBox.BackColor = Color.White;
            blueHistogramPictureBox.Dock = DockStyle.Top;
            blueHistogramPictureBox.Location = new Point(3, 279);
            blueHistogramPictureBox.Name = "blueHistogramPictureBox";
            blueHistogramPictureBox.Size = new Size(256, 130);
            blueHistogramPictureBox.TabIndex = 2;
            blueHistogramPictureBox.TabStop = false;
            blueHistogramPictureBox.Paint += blueHistogramPictureBox_Paint;
            // 
            // greenHistogramPictureBox
            // 
            greenHistogramPictureBox.BackColor = Color.White;
            greenHistogramPictureBox.Dock = DockStyle.Top;
            greenHistogramPictureBox.Location = new Point(3, 149);
            greenHistogramPictureBox.Name = "greenHistogramPictureBox";
            greenHistogramPictureBox.Size = new Size(256, 130);
            greenHistogramPictureBox.TabIndex = 1;
            greenHistogramPictureBox.TabStop = false;
            greenHistogramPictureBox.Paint += greenHistogramPictureBox_Paint;
            // 
            // redHistogramPictureBox
            // 
            redHistogramPictureBox.BackColor = Color.White;
            redHistogramPictureBox.Dock = DockStyle.Top;
            redHistogramPictureBox.Location = new Point(3, 19);
            redHistogramPictureBox.Name = "redHistogramPictureBox";
            redHistogramPictureBox.Size = new Size(256, 130);
            redHistogramPictureBox.TabIndex = 0;
            redHistogramPictureBox.TabStop = false;
            redHistogramPictureBox.Paint += redHistogramPictureBox_Paint;
            // 
            // chooseFileDialog
            // 
            chooseFileDialog.FileName = "openFileDialog1";
            chooseFileDialog.FileOk += openFileDialog1_FileOk;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1059, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chooseToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // chooseToolStripMenuItem
            // 
            chooseToolStripMenuItem.Name = "chooseToolStripMenuItem";
            chooseToolStripMenuItem.Size = new Size(110, 22);
            chooseToolStripMenuItem.Text = "Import";
            chooseToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(262, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // Application
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 450);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Application";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            histogramGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)blueHistogramPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenHistogramPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)redHistogramPictureBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox canvas;
        private OpenFileDialog chooseFileDialog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem chooseToolStripMenuItem;
        private GroupBox histogramGroupBox;
        private PictureBox redHistogramPictureBox;
        private PictureBox blueHistogramPictureBox;
        private PictureBox greenHistogramPictureBox;
        private GroupBox groupBox1;
    }
}
