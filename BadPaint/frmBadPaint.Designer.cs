namespace BadPaint
{
    partial class frmBadPaint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBadPaint));
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgCustomPalette = new System.Windows.Forms.ColorDialog();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.pnlPalette = new System.Windows.Forms.Panel();
            this.btnChangeCustomColor = new System.Windows.Forms.Button();
            this.boxPaletteCustom = new System.Windows.Forms.PictureBox();
            this.nudPaletteNum = new System.Windows.Forms.NumericUpDown();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.boxOpen = new System.Windows.Forms.PictureBox();
            this.boxSave = new System.Windows.Forms.PictureBox();
            this.lblLineWidth = new System.Windows.Forms.Label();
            this.boxFill = new System.Windows.Forms.PictureBox();
            this.nudLineWidth = new System.Windows.Forms.NumericUpDown();
            this.boxPaletteSelected2 = new System.Windows.Forms.PictureBox();
            this.boxPaletteSelected1 = new System.Windows.Forms.PictureBox();
            this.boxPalette16 = new System.Windows.Forms.PictureBox();
            this.boxPalette15 = new System.Windows.Forms.PictureBox();
            this.boxPalette14 = new System.Windows.Forms.PictureBox();
            this.boxPalette13 = new System.Windows.Forms.PictureBox();
            this.boxPalette12 = new System.Windows.Forms.PictureBox();
            this.boxPalette11 = new System.Windows.Forms.PictureBox();
            this.boxPalette10 = new System.Windows.Forms.PictureBox();
            this.boxPalette9 = new System.Windows.Forms.PictureBox();
            this.boxPalette7 = new System.Windows.Forms.PictureBox();
            this.boxPalette6 = new System.Windows.Forms.PictureBox();
            this.boxPalette8 = new System.Windows.Forms.PictureBox();
            this.boxPalette5 = new System.Windows.Forms.PictureBox();
            this.boxPalette4 = new System.Windows.Forms.PictureBox();
            this.boxPalette3 = new System.Windows.Forms.PictureBox();
            this.boxPalette2 = new System.Windows.Forms.PictureBox();
            this.boxPalette1 = new System.Windows.Forms.PictureBox();
            this.pnlPalette.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxPaletteCustom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaletteNum)).BeginInit();
            this.pnlConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxFill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPaletteSelected2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPaletteSelected1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.White;
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCanvas.Location = new System.Drawing.Point(0, 38);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(956, 604);
            this.pnlCanvas.TabIndex = 0;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            this.pnlCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseDown);
            this.pnlCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseMove);
            this.pnlCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseUp);
            // 
            // dlgSave
            // 
            this.dlgSave.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // pnlPalette
            // 
            this.pnlPalette.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPalette.BackgroundImage = global::BadPaint.Properties.Resources.carpet;
            this.pnlPalette.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPalette.Controls.Add(this.btnChangeCustomColor);
            this.pnlPalette.Controls.Add(this.boxPaletteCustom);
            this.pnlPalette.Controls.Add(this.nudPaletteNum);
            this.pnlPalette.Controls.Add(this.pnlConfig);
            this.pnlPalette.Controls.Add(this.boxPaletteSelected2);
            this.pnlPalette.Controls.Add(this.boxPaletteSelected1);
            this.pnlPalette.Controls.Add(this.boxPalette16);
            this.pnlPalette.Controls.Add(this.boxPalette15);
            this.pnlPalette.Controls.Add(this.boxPalette14);
            this.pnlPalette.Controls.Add(this.boxPalette13);
            this.pnlPalette.Controls.Add(this.boxPalette12);
            this.pnlPalette.Controls.Add(this.boxPalette11);
            this.pnlPalette.Controls.Add(this.boxPalette10);
            this.pnlPalette.Controls.Add(this.boxPalette9);
            this.pnlPalette.Controls.Add(this.boxPalette7);
            this.pnlPalette.Controls.Add(this.boxPalette6);
            this.pnlPalette.Controls.Add(this.boxPalette8);
            this.pnlPalette.Controls.Add(this.boxPalette5);
            this.pnlPalette.Controls.Add(this.boxPalette4);
            this.pnlPalette.Controls.Add(this.boxPalette3);
            this.pnlPalette.Controls.Add(this.boxPalette2);
            this.pnlPalette.Controls.Add(this.boxPalette1);
            this.pnlPalette.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPalette.Location = new System.Drawing.Point(0, 0);
            this.pnlPalette.Name = "pnlPalette";
            this.pnlPalette.Size = new System.Drawing.Size(956, 38);
            this.pnlPalette.TabIndex = 0;
            // 
            // btnChangeCustomColor
            // 
            this.btnChangeCustomColor.Location = new System.Drawing.Point(724, 3);
            this.btnChangeCustomColor.Name = "btnChangeCustomColor";
            this.btnChangeCustomColor.Size = new System.Drawing.Size(19, 19);
            this.btnChangeCustomColor.TabIndex = 22;
            this.btnChangeCustomColor.Text = "!";
            this.btnChangeCustomColor.UseVisualStyleBackColor = true;
            this.btnChangeCustomColor.Click += new System.EventHandler(this.btnChangeCustomColor_Click);
            // 
            // boxPaletteCustom
            // 
            this.boxPaletteCustom.BackColor = System.Drawing.Color.Black;
            this.boxPaletteCustom.Location = new System.Drawing.Point(711, 3);
            this.boxPaletteCustom.Name = "boxPaletteCustom";
            this.boxPaletteCustom.Size = new System.Drawing.Size(32, 32);
            this.boxPaletteCustom.TabIndex = 21;
            this.boxPaletteCustom.TabStop = false;
            this.boxPaletteCustom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_palette_MouseDown);
            // 
            // nudPaletteNum
            // 
            this.nudPaletteNum.Location = new System.Drawing.Point(663, 7);
            this.nudPaletteNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudPaletteNum.Name = "nudPaletteNum";
            this.nudPaletteNum.Size = new System.Drawing.Size(45, 20);
            this.nudPaletteNum.TabIndex = 20;
            this.nudPaletteNum.ValueChanged += new System.EventHandler(this.nudPaletteNum_ValueChanged);
            // 
            // pnlConfig
            // 
            this.pnlConfig.BackColor = System.Drawing.SystemColors.Control;
            this.pnlConfig.Controls.Add(this.boxOpen);
            this.pnlConfig.Controls.Add(this.boxSave);
            this.pnlConfig.Controls.Add(this.lblLineWidth);
            this.pnlConfig.Controls.Add(this.boxFill);
            this.pnlConfig.Controls.Add(this.nudLineWidth);
            this.pnlConfig.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlConfig.Location = new System.Drawing.Point(762, 0);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(192, 36);
            this.pnlConfig.TabIndex = 1;
            // 
            // boxOpen
            // 
            this.boxOpen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxOpen.Image = global::BadPaint.Properties.Resources.Open_6529;
            this.boxOpen.Location = new System.Drawing.Point(3, 16);
            this.boxOpen.Name = "boxOpen";
            this.boxOpen.Size = new System.Drawing.Size(32, 16);
            this.boxOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxOpen.TabIndex = 14;
            this.boxOpen.TabStop = false;
            this.boxOpen.Click += new System.EventHandler(this.boxOpen_Click);
            // 
            // boxSave
            // 
            this.boxSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxSave.Image = global::BadPaint.Properties.Resources.Save_6530;
            this.boxSave.Location = new System.Drawing.Point(3, 3);
            this.boxSave.Name = "boxSave";
            this.boxSave.Size = new System.Drawing.Size(32, 16);
            this.boxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxSave.TabIndex = 13;
            this.boxSave.TabStop = false;
            this.boxSave.Click += new System.EventHandler(this.boxSave_Click);
            // 
            // lblLineWidth
            // 
            this.lblLineWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLineWidth.AutoSize = true;
            this.lblLineWidth.Location = new System.Drawing.Point(79, 9);
            this.lblLineWidth.Name = "lblLineWidth";
            this.lblLineWidth.Size = new System.Drawing.Size(58, 13);
            this.lblLineWidth.TabIndex = 11;
            this.lblLineWidth.Text = "Line Width";
            // 
            // boxFill
            // 
            this.boxFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxFill.BackColor = System.Drawing.SystemColors.ControlLight;
            this.boxFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxFill.Image = ((System.Drawing.Image)(resources.GetObject("boxFill.Image")));
            this.boxFill.InitialImage = ((System.Drawing.Image)(resources.GetObject("boxFill.InitialImage")));
            this.boxFill.Location = new System.Drawing.Point(38, 3);
            this.boxFill.Name = "boxFill";
            this.boxFill.Size = new System.Drawing.Size(32, 32);
            this.boxFill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxFill.TabIndex = 12;
            this.boxFill.TabStop = false;
            this.boxFill.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boxFill_MouseDown);
            // 
            // nudLineWidth
            // 
            this.nudLineWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudLineWidth.Location = new System.Drawing.Point(143, 7);
            this.nudLineWidth.Name = "nudLineWidth";
            this.nudLineWidth.Size = new System.Drawing.Size(46, 20);
            this.nudLineWidth.TabIndex = 1;
            this.nudLineWidth.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudLineWidth.ValueChanged += new System.EventHandler(this.nudLineWidth_ValueChanged);
            // 
            // boxPaletteSelected2
            // 
            this.boxPaletteSelected2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxPaletteSelected2.Location = new System.Drawing.Point(27, 3);
            this.boxPaletteSelected2.Name = "boxPaletteSelected2";
            this.boxPaletteSelected2.Size = new System.Drawing.Size(24, 32);
            this.boxPaletteSelected2.TabIndex = 19;
            this.boxPaletteSelected2.TabStop = false;
            // 
            // boxPaletteSelected1
            // 
            this.boxPaletteSelected1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxPaletteSelected1.Location = new System.Drawing.Point(3, 3);
            this.boxPaletteSelected1.Name = "boxPaletteSelected1";
            this.boxPaletteSelected1.Size = new System.Drawing.Size(24, 32);
            this.boxPaletteSelected1.TabIndex = 1;
            this.boxPaletteSelected1.TabStop = false;
            // 
            // boxPalette16
            // 
            this.boxPalette16.BackColor = System.Drawing.Color.Black;
            this.boxPalette16.Location = new System.Drawing.Point(625, 3);
            this.boxPalette16.Name = "boxPalette16";
            this.boxPalette16.Size = new System.Drawing.Size(32, 32);
            this.boxPalette16.TabIndex = 17;
            this.boxPalette16.TabStop = false;
            this.boxPalette16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_palette_MouseDown);
            // 
            // boxPalette15
            // 
            this.boxPalette15.BackColor = System.Drawing.Color.Black;
            this.boxPalette15.Location = new System.Drawing.Point(587, 3);
            this.boxPalette15.Name = "boxPalette15";
            this.boxPalette15.Size = new System.Drawing.Size(32, 32);
            this.boxPalette15.TabIndex = 16;
            this.boxPalette15.TabStop = false;
            this.boxPalette15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_palette_MouseDown);
            // 
            // boxPalette14
            // 
            this.boxPalette14.BackColor = System.Drawing.Color.Black;
            this.boxPalette14.Location = new System.Drawing.Point(549, 3);
            this.boxPalette14.Name = "boxPalette14";
            this.boxPalette14.Size = new System.Drawing.Size(32, 32);
            this.boxPalette14.TabIndex = 15;
            this.boxPalette14.TabStop = false;
            this.boxPalette14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_palette_MouseDown);
            // 
            // boxPalette13
            // 
            this.boxPalette13.BackColor = System.Drawing.Color.Black;
            this.boxPalette13.Location = new System.Drawing.Point(511, 3);
            this.boxPalette13.Name = "boxPalette13";
            this.boxPalette13.Size = new System.Drawing.Size(32, 32);
            this.boxPalette13.TabIndex = 14;
            this.boxPalette13.TabStop = false;
            this.boxPalette13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_palette_MouseDown);
            // 
            // boxPalette12
            // 
            this.boxPalette12.BackColor = System.Drawing.Color.Black;
            this.boxPalette12.Location = new System.Drawing.Point(473, 3);
            this.boxPalette12.Name = "boxPalette12";
            this.boxPalette12.Size = new System.Drawing.Size(32, 32);
            this.boxPalette12.TabIndex = 13;
            this.boxPalette12.TabStop = false;
            this.boxPalette12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_palette_MouseDown);
            // 
            // boxPalette11
            // 
            this.boxPalette11.BackColor = System.Drawing.Color.Black;
            this.boxPalette11.Location = new System.Drawing.Point(435, 3);
            this.boxPalette11.Name = "boxPalette11";
            this.boxPalette11.Size = new System.Drawing.Size(32, 32);
            this.boxPalette11.TabIndex = 12;
            this.boxPalette11.TabStop = false;
            this.boxPalette11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_palette_MouseDown);
            // 
            // boxPalette10
            // 
            this.boxPalette10.BackColor = System.Drawing.Color.Black;
            this.boxPalette10.Location = new System.Drawing.Point(397, 3);
            this.boxPalette10.Name = "boxPalette10";
            this.boxPalette10.Size = new System.Drawing.Size(32, 32);
            this.boxPalette10.TabIndex = 11;
            this.boxPalette10.TabStop = false;
            this.boxPalette10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_palette_MouseDown);
            // 
            // boxPalette9
            // 
            this.boxPalette9.BackColor = System.Drawing.Color.Black;
            this.boxPalette9.Location = new System.Drawing.Point(359, 3);
            this.boxPalette9.Name = "boxPalette9";
            this.boxPalette9.Size = new System.Drawing.Size(32, 32);
            this.boxPalette9.TabIndex = 10;
            this.boxPalette9.TabStop = false;
            this.boxPalette9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_palette_MouseDown);
            // 
            // boxPalette7
            // 
            this.boxPalette7.BackColor = System.Drawing.Color.Violet;
            this.boxPalette7.Location = new System.Drawing.Point(283, 3);
            this.boxPalette7.Name = "boxPalette7";
            this.boxPalette7.Size = new System.Drawing.Size(32, 32);
            this.boxPalette7.TabIndex = 8;
            this.boxPalette7.TabStop = false;
            this.boxPalette7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_palette_MouseDown);
            // 
            // boxPalette6
            // 
            this.boxPalette6.BackColor = System.Drawing.Color.Indigo;
            this.boxPalette6.Location = new System.Drawing.Point(245, 3);
            this.boxPalette6.Name = "boxPalette6";
            this.boxPalette6.Size = new System.Drawing.Size(32, 32);
            this.boxPalette6.TabIndex = 7;
            this.boxPalette6.TabStop = false;
            this.boxPalette6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_palette_MouseDown);
            // 
            // boxPalette8
            // 
            this.boxPalette8.BackColor = System.Drawing.Color.White;
            this.boxPalette8.Location = new System.Drawing.Point(321, 3);
            this.boxPalette8.Name = "boxPalette8";
            this.boxPalette8.Size = new System.Drawing.Size(32, 32);
            this.boxPalette8.TabIndex = 9;
            this.boxPalette8.TabStop = false;
            this.boxPalette8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_palette_MouseDown);
            // 
            // boxPalette5
            // 
            this.boxPalette5.BackColor = System.Drawing.Color.Blue;
            this.boxPalette5.Location = new System.Drawing.Point(207, 3);
            this.boxPalette5.Name = "boxPalette5";
            this.boxPalette5.Size = new System.Drawing.Size(32, 32);
            this.boxPalette5.TabIndex = 6;
            this.boxPalette5.TabStop = false;
            this.boxPalette5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_palette_MouseDown);
            // 
            // boxPalette4
            // 
            this.boxPalette4.BackColor = System.Drawing.Color.Green;
            this.boxPalette4.Location = new System.Drawing.Point(169, 3);
            this.boxPalette4.Name = "boxPalette4";
            this.boxPalette4.Size = new System.Drawing.Size(32, 32);
            this.boxPalette4.TabIndex = 3;
            this.boxPalette4.TabStop = false;
            this.boxPalette4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_palette_MouseDown);
            // 
            // boxPalette3
            // 
            this.boxPalette3.BackColor = System.Drawing.Color.Yellow;
            this.boxPalette3.Location = new System.Drawing.Point(133, 3);
            this.boxPalette3.Name = "boxPalette3";
            this.boxPalette3.Size = new System.Drawing.Size(32, 32);
            this.boxPalette3.TabIndex = 2;
            this.boxPalette3.TabStop = false;
            this.boxPalette3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_palette_MouseDown);
            // 
            // boxPalette2
            // 
            this.boxPalette2.BackColor = System.Drawing.Color.Orange;
            this.boxPalette2.Location = new System.Drawing.Point(95, 3);
            this.boxPalette2.Name = "boxPalette2";
            this.boxPalette2.Size = new System.Drawing.Size(32, 32);
            this.boxPalette2.TabIndex = 1;
            this.boxPalette2.TabStop = false;
            this.boxPalette2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_palette_MouseDown);
            // 
            // boxPalette1
            // 
            this.boxPalette1.BackColor = System.Drawing.Color.Red;
            this.boxPalette1.Location = new System.Drawing.Point(57, 3);
            this.boxPalette1.Name = "boxPalette1";
            this.boxPalette1.Size = new System.Drawing.Size(32, 32);
            this.boxPalette1.TabIndex = 0;
            this.boxPalette1.TabStop = false;
            this.boxPalette1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.box_palette_MouseDown);
            // 
            // frmBadPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 642);
            this.Controls.Add(this.pnlPalette);
            this.Controls.Add(this.pnlCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBadPaint";
            this.Text = "Bad Paint";
            this.Load += new System.EventHandler(this.frmBadPaint_Load);
            this.pnlPalette.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boxPaletteCustom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaletteNum)).EndInit();
            this.pnlConfig.ResumeLayout(false);
            this.pnlConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxFill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPaletteSelected2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPaletteSelected1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPalette1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Panel pnlPalette;
        private System.Windows.Forms.PictureBox boxPalette4;
        private System.Windows.Forms.PictureBox boxPalette3;
        private System.Windows.Forms.PictureBox boxPalette2;
        private System.Windows.Forms.PictureBox boxPalette1;
        private System.Windows.Forms.PictureBox boxPalette7;
        private System.Windows.Forms.PictureBox boxPalette6;
        private System.Windows.Forms.PictureBox boxPalette5;
        private System.Windows.Forms.PictureBox boxPalette9;
        private System.Windows.Forms.PictureBox boxPalette8;
        private System.Windows.Forms.NumericUpDown nudLineWidth;
        private System.Windows.Forms.Panel pnlConfig;
        private System.Windows.Forms.Label lblLineWidth;
        private System.Windows.Forms.PictureBox boxFill;
        private System.Windows.Forms.PictureBox boxPalette16;
        private System.Windows.Forms.PictureBox boxPalette15;
        private System.Windows.Forms.PictureBox boxPalette14;
        private System.Windows.Forms.PictureBox boxPalette13;
        private System.Windows.Forms.PictureBox boxPalette12;
        private System.Windows.Forms.PictureBox boxPalette11;
        private System.Windows.Forms.PictureBox boxPalette10;
        private System.Windows.Forms.PictureBox boxPaletteSelected1;
        private System.Windows.Forms.PictureBox boxPaletteSelected2;
        private System.Windows.Forms.NumericUpDown nudPaletteNum;
        private System.Windows.Forms.PictureBox boxSave;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.PictureBox boxPaletteCustom;
        private System.Windows.Forms.ColorDialog dlgCustomPalette;
        private System.Windows.Forms.Button btnChangeCustomColor;
        private System.Windows.Forms.PictureBox boxOpen;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
    }
}

