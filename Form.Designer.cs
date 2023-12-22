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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            brushRadiusSlider = new TrackBar();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            histogramGroupBox = new GroupBox();
            blueHistogramPictureBox = new PictureBox();
            greenHistogramPictureBox = new PictureBox();
            redHistogramPictureBox = new PictureBox();
            chooseFileDialog = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            chooseToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brushRadiusSlider).BeginInit();
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
            canvas.Click += canvas_Click;
            canvas.Paint += canvas_Paint;
            canvas.MouseClick += canvas_MouseClick;
            canvas.MouseDown += canvas_MouseDown;
            canvas.MouseMove += canvas_MouseMove;
            canvas.MouseUp += canvas_MouseUp;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(291, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(brushRadiusSlider);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(3, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(326, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Region";
            // 
            // brushRadiusSlider
            // 
            brushRadiusSlider.Dock = DockStyle.Top;
            brushRadiusSlider.Location = new Point(3, 57);
            brushRadiusSlider.Maximum = 100;
            brushRadiusSlider.Name = "brushRadiusSlider";
            brushRadiusSlider.Size = new Size(320, 45);
            brushRadiusSlider.TabIndex = 2;
            brushRadiusSlider.TickFrequency = 10;
            brushRadiusSlider.Value = 30;
            brushRadiusSlider.ValueChanged += brushRadiusSlider_ValueChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Dock = DockStyle.Top;
            radioButton2.Location = new Point(3, 38);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(320, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Brush";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Dock = DockStyle.Top;
            radioButton1.Location = new Point(3, 19);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(320, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Whole image";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // histogramGroupBox
            // 
            histogramGroupBox.Controls.Add(blueHistogramPictureBox);
            histogramGroupBox.Controls.Add(greenHistogramPictureBox);
            histogramGroupBox.Controls.Add(redHistogramPictureBox);
            histogramGroupBox.Dock = DockStyle.Left;
            histogramGroupBox.Location = new Point(0, 0);
            histogramGroupBox.Name = "histogramGroupBox";
            histogramGroupBox.Size = new Size(291, 426);
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
            blueHistogramPictureBox.Size = new Size(285, 130);
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
            greenHistogramPictureBox.Size = new Size(285, 130);
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
            redHistogramPictureBox.Size = new Size(285, 130);
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
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)brushRadiusSlider).EndInit();
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
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TrackBar brushRadiusSlider;
    }
}
