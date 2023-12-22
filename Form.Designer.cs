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
            groupBox3 = new GroupBox();
            panel6 = new Panel();
            offsetSlider = new TrackBar();
            label2 = new Label();
            panel5 = new Panel();
            divisorInput = new NumericUpDown();
            autoDivisorCheckBox = new CheckBox();
            label1 = new Label();
            filterTypeComboBox = new ComboBox();
            groupBox4 = new GroupBox();
            panel3 = new Panel();
            m22Input = new NumericUpDown();
            m21Input = new NumericUpDown();
            m20Input = new NumericUpDown();
            panel2 = new Panel();
            m12Input = new NumericUpDown();
            m11Input = new NumericUpDown();
            m10Input = new NumericUpDown();
            panel1 = new Panel();
            m02Input = new NumericUpDown();
            m01Input = new NumericUpDown();
            m00Input = new NumericUpDown();
            groupBox2 = new GroupBox();
            eraseCheckBox = new CheckBox();
            polygonRadioButton = new RadioButton();
            brushRadiusSlider = new TrackBar();
            brushRadioButton = new RadioButton();
            panel4 = new Panel();
            button1 = new Button();
            wholeImageButton = new Button();
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
            groupBox3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)offsetSlider).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)divisorInput).BeginInit();
            groupBox4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)m22Input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)m21Input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)m20Input).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)m12Input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)m11Input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)m10Input).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)m02Input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)m01Input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)m00Input).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brushRadiusSlider).BeginInit();
            panel4.SuspendLayout();
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
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(canvas);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Panel2.Controls.Add(histogramGroupBox);
            splitContainer1.Size = new Size(953, 426);
            splitContainer1.SplitterDistance = 440;
            splitContainer1.TabIndex = 0;
            // 
            // canvas
            // 
            canvas.Dock = DockStyle.Fill;
            canvas.Location = new Point(0, 0);
            canvas.Name = "canvas";
            canvas.Size = new Size(440, 426);
            canvas.TabIndex = 0;
            canvas.TabStop = false;
            canvas.Paint += canvas_Paint;
            canvas.MouseClick += canvas_MouseClick;
            canvas.MouseDown += canvas_MouseDown;
            canvas.MouseMove += canvas_MouseMove;
            canvas.MouseUp += canvas_MouseUp;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(263, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel6);
            groupBox3.Controls.Add(panel5);
            groupBox3.Controls.Add(filterTypeComboBox);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 172);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(7, 3, 7, 3);
            groupBox3.Size = new Size(240, 251);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Type";
            // 
            // panel6
            // 
            panel6.Controls.Add(offsetSlider);
            panel6.Controls.Add(label2);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(7, 71);
            panel6.Name = "panel6";
            panel6.Size = new Size(226, 28);
            panel6.TabIndex = 7;
            // 
            // offsetSlider
            // 
            offsetSlider.Dock = DockStyle.Right;
            offsetSlider.Location = new Point(55, 0);
            offsetSlider.Maximum = 100;
            offsetSlider.Minimum = -100;
            offsetSlider.Name = "offsetSlider";
            offsetSlider.Size = new Size(171, 28);
            offsetSlider.TabIndex = 7;
            offsetSlider.TickFrequency = 20;
            offsetSlider.Scroll += offsetSlider_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(3, 6, 3, 6);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 5, 0, 5);
            label2.Size = new Size(39, 25);
            label2.TabIndex = 6;
            label2.Text = "Offset";
            // 
            // panel5
            // 
            panel5.Controls.Add(divisorInput);
            panel5.Controls.Add(autoDivisorCheckBox);
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(7, 42);
            panel5.Name = "panel5";
            panel5.Size = new Size(226, 29);
            panel5.TabIndex = 6;
            // 
            // divisorInput
            // 
            divisorInput.Location = new Point(55, 3);
            divisorInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            divisorInput.Name = "divisorInput";
            divisorInput.Size = new Size(52, 23);
            divisorInput.TabIndex = 3;
            divisorInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            divisorInput.ValueChanged += divisorInput_ValueChanged;
            // 
            // autoDivisorCheckBox
            // 
            autoDivisorCheckBox.AutoSize = true;
            autoDivisorCheckBox.Location = new Point(126, 7);
            autoDivisorCheckBox.Name = "autoDivisorCheckBox";
            autoDivisorCheckBox.Size = new Size(99, 19);
            autoDivisorCheckBox.TabIndex = 1;
            autoDivisorCheckBox.Text = "Autocalculate";
            autoDivisorCheckBox.UseVisualStyleBackColor = true;
            autoDivisorCheckBox.CheckedChanged += autoDivisorCheckBox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(3, 6, 3, 6);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 5, 0, 5);
            label1.Size = new Size(43, 25);
            label1.TabIndex = 5;
            label1.Text = "Divisor";
            // 
            // filterTypeComboBox
            // 
            filterTypeComboBox.Dock = DockStyle.Top;
            filterTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            filterTypeComboBox.FormattingEnabled = true;
            filterTypeComboBox.Items.AddRange(new object[] { "Identity", "Edge detection", "Sharpen", "Box blur", "Gaussian blur", "Sculpt SE", "Custom" });
            filterTypeComboBox.Location = new Point(7, 19);
            filterTypeComboBox.Name = "filterTypeComboBox";
            filterTypeComboBox.Size = new Size(226, 23);
            filterTypeComboBox.TabIndex = 0;
            filterTypeComboBox.SelectedIndexChanged += filterTypeComboBox_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(panel3);
            groupBox4.Controls.Add(panel2);
            groupBox4.Controls.Add(panel1);
            groupBox4.Dock = DockStyle.Bottom;
            groupBox4.Location = new Point(7, 107);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(226, 141);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Filter matrix";
            // 
            // panel3
            // 
            panel3.Controls.Add(m22Input);
            panel3.Controls.Add(m21Input);
            panel3.Controls.Add(m20Input);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 81);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 31);
            panel3.TabIndex = 3;
            // 
            // m22Input
            // 
            m22Input.Dock = DockStyle.Left;
            m22Input.Location = new Point(104, 0);
            m22Input.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            m22Input.Name = "m22Input";
            m22Input.Size = new Size(52, 23);
            m22Input.TabIndex = 2;
            m22Input.ValueChanged += m22Input_ValueChanged;
            // 
            // m21Input
            // 
            m21Input.Dock = DockStyle.Left;
            m21Input.Location = new Point(52, 0);
            m21Input.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            m21Input.Name = "m21Input";
            m21Input.Size = new Size(52, 23);
            m21Input.TabIndex = 1;
            m21Input.ValueChanged += m21Input_ValueChanged;
            // 
            // m20Input
            // 
            m20Input.Dock = DockStyle.Left;
            m20Input.Location = new Point(0, 0);
            m20Input.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            m20Input.Name = "m20Input";
            m20Input.Size = new Size(52, 23);
            m20Input.TabIndex = 0;
            m20Input.ValueChanged += m20Input_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(m12Input);
            panel2.Controls.Add(m11Input);
            panel2.Controls.Add(m10Input);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 31);
            panel2.TabIndex = 2;
            // 
            // m12Input
            // 
            m12Input.Dock = DockStyle.Left;
            m12Input.Location = new Point(104, 0);
            m12Input.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            m12Input.Name = "m12Input";
            m12Input.Size = new Size(52, 23);
            m12Input.TabIndex = 2;
            m12Input.ValueChanged += m12Input_ValueChanged;
            // 
            // m11Input
            // 
            m11Input.Dock = DockStyle.Left;
            m11Input.Location = new Point(52, 0);
            m11Input.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            m11Input.Name = "m11Input";
            m11Input.Size = new Size(52, 23);
            m11Input.TabIndex = 1;
            m11Input.ValueChanged += m11Input_ValueChanged;
            // 
            // m10Input
            // 
            m10Input.Dock = DockStyle.Left;
            m10Input.Location = new Point(0, 0);
            m10Input.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            m10Input.Name = "m10Input";
            m10Input.Size = new Size(52, 23);
            m10Input.TabIndex = 0;
            m10Input.ValueChanged += m10Input_ValueChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(m02Input);
            panel1.Controls.Add(m01Input);
            panel1.Controls.Add(m00Input);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 31);
            panel1.TabIndex = 1;
            // 
            // m02Input
            // 
            m02Input.Dock = DockStyle.Left;
            m02Input.Location = new Point(104, 0);
            m02Input.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            m02Input.Name = "m02Input";
            m02Input.Size = new Size(52, 23);
            m02Input.TabIndex = 2;
            m02Input.ValueChanged += m02Input_ValueChanged;
            // 
            // m01Input
            // 
            m01Input.Dock = DockStyle.Left;
            m01Input.Location = new Point(52, 0);
            m01Input.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            m01Input.Name = "m01Input";
            m01Input.Size = new Size(52, 23);
            m01Input.TabIndex = 1;
            m01Input.ValueChanged += m01Input_ValueChanged;
            // 
            // m00Input
            // 
            m00Input.Dock = DockStyle.Left;
            m00Input.Location = new Point(0, 0);
            m00Input.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            m00Input.Name = "m00Input";
            m00Input.Size = new Size(52, 23);
            m00Input.TabIndex = 0;
            m00Input.ValueChanged += m00Input_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(eraseCheckBox);
            groupBox2.Controls.Add(polygonRadioButton);
            groupBox2.Controls.Add(brushRadiusSlider);
            groupBox2.Controls.Add(brushRadioButton);
            groupBox2.Controls.Add(panel4);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(3, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(7, 3, 7, 3);
            groupBox2.Size = new Size(240, 153);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Region";
            // 
            // eraseCheckBox
            // 
            eraseCheckBox.AutoSize = true;
            eraseCheckBox.Dock = DockStyle.Bottom;
            eraseCheckBox.Location = new Point(7, 131);
            eraseCheckBox.Name = "eraseCheckBox";
            eraseCheckBox.Size = new Size(226, 19);
            eraseCheckBox.TabIndex = 6;
            eraseCheckBox.Text = "Erase";
            eraseCheckBox.UseVisualStyleBackColor = true;
            // 
            // polygonRadioButton
            // 
            polygonRadioButton.AutoSize = true;
            polygonRadioButton.Dock = DockStyle.Top;
            polygonRadioButton.Location = new Point(7, 106);
            polygonRadioButton.Name = "polygonRadioButton";
            polygonRadioButton.Size = new Size(226, 19);
            polygonRadioButton.TabIndex = 3;
            polygonRadioButton.TabStop = true;
            polygonRadioButton.Text = "Polygon";
            polygonRadioButton.UseVisualStyleBackColor = true;
            polygonRadioButton.CheckedChanged += polygonRadioButton_CheckedChanged;
            // 
            // brushRadiusSlider
            // 
            brushRadiusSlider.Dock = DockStyle.Top;
            brushRadiusSlider.Location = new Point(7, 61);
            brushRadiusSlider.Maximum = 100;
            brushRadiusSlider.Name = "brushRadiusSlider";
            brushRadiusSlider.Size = new Size(226, 45);
            brushRadiusSlider.TabIndex = 2;
            brushRadiusSlider.TickFrequency = 10;
            brushRadiusSlider.Value = 30;
            brushRadiusSlider.ValueChanged += brushRadiusSlider_ValueChanged;
            // 
            // brushRadioButton
            // 
            brushRadioButton.AutoSize = true;
            brushRadioButton.Dock = DockStyle.Top;
            brushRadioButton.Location = new Point(7, 42);
            brushRadioButton.Name = "brushRadioButton";
            brushRadioButton.Size = new Size(226, 19);
            brushRadioButton.TabIndex = 1;
            brushRadioButton.TabStop = true;
            brushRadioButton.Text = "Brush";
            brushRadioButton.UseVisualStyleBackColor = true;
            brushRadioButton.CheckedChanged += brushRadioButton_CheckedChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Controls.Add(wholeImageButton);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(7, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(226, 23);
            panel4.TabIndex = 5;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(134, 0);
            button1.Name = "button1";
            button1.Size = new Size(92, 23);
            button1.TabIndex = 5;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += resetButton_Click;
            // 
            // wholeImageButton
            // 
            wholeImageButton.Dock = DockStyle.Left;
            wholeImageButton.Location = new Point(0, 0);
            wholeImageButton.Name = "wholeImageButton";
            wholeImageButton.Size = new Size(89, 23);
            wholeImageButton.TabIndex = 4;
            wholeImageButton.Text = "Whole image";
            wholeImageButton.UseVisualStyleBackColor = true;
            wholeImageButton.Click += wholeImageButton_Click;
            // 
            // histogramGroupBox
            // 
            histogramGroupBox.Controls.Add(blueHistogramPictureBox);
            histogramGroupBox.Controls.Add(greenHistogramPictureBox);
            histogramGroupBox.Controls.Add(redHistogramPictureBox);
            histogramGroupBox.Dock = DockStyle.Left;
            histogramGroupBox.Location = new Point(0, 0);
            histogramGroupBox.Name = "histogramGroupBox";
            histogramGroupBox.Size = new Size(263, 426);
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
            blueHistogramPictureBox.Size = new Size(257, 130);
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
            greenHistogramPictureBox.Size = new Size(257, 130);
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
            redHistogramPictureBox.Size = new Size(257, 130);
            redHistogramPictureBox.TabIndex = 0;
            redHistogramPictureBox.TabStop = false;
            redHistogramPictureBox.Paint += redHistogramPictureBox_Paint;
            // 
            // chooseFileDialog
            // 
            chooseFileDialog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(953, 24);
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
            ClientSize = new Size(953, 450);
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
            groupBox3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)offsetSlider).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)divisorInput).EndInit();
            groupBox4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)m22Input).EndInit();
            ((System.ComponentModel.ISupportInitialize)m21Input).EndInit();
            ((System.ComponentModel.ISupportInitialize)m20Input).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)m12Input).EndInit();
            ((System.ComponentModel.ISupportInitialize)m11Input).EndInit();
            ((System.ComponentModel.ISupportInitialize)m10Input).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)m02Input).EndInit();
            ((System.ComponentModel.ISupportInitialize)m01Input).EndInit();
            ((System.ComponentModel.ISupportInitialize)m00Input).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)brushRadiusSlider).EndInit();
            panel4.ResumeLayout(false);
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
        private RadioButton brushRadioButton;
        private TrackBar brushRadiusSlider;
        private RadioButton polygonRadioButton;
        private GroupBox groupBox3;
        private ComboBox filterTypeComboBox;
        private CheckBox autoDivisorCheckBox;
        private NumericUpDown divisorInput;
        private GroupBox groupBox4;
        private Panel panel1;
        private NumericUpDown m00Input;
        private NumericUpDown m02Input;
        private NumericUpDown m01Input;
        private Panel panel3;
        private NumericUpDown m22Input;
        private NumericUpDown m21Input;
        private NumericUpDown m20Input;
        private Panel panel2;
        private NumericUpDown m12Input;
        private NumericUpDown m11Input;
        private NumericUpDown m10Input;
        private Panel panel4;
        private Button button1;
        private Button wholeImageButton;
        private CheckBox eraseCheckBox;
        private Label label1;
        private Panel panel5;
        private Panel panel6;
        private Label label2;
        private TrackBar offsetSlider;
    }
}
