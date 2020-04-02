namespace project
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProgramDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button17 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(712, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picOriginal_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picOriginal_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picOriginal_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(832, 76);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(298, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.BrightnessAdjustment);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(833, 127);
            this.trackBar2.Maximum = 50;
            this.trackBar2.Minimum = -50;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(298, 45);
            this.trackBar2.TabIndex = 4;
            this.trackBar2.Scroll += new System.EventHandler(this.ContrastAdjustment);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(829, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Brightness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(830, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contrast";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1209, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.openImageToolStripMenuItem,
            this.openProgramDirectoryToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.imageToolStripMenuItem.Text = "Image Menu";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.saveAsToolStripMenuItem.Text = "Save As..";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveImage);
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.openImageToolStripMenuItem.Text = "Open image...";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.UploadImage);
            // 
            // openProgramDirectoryToolStripMenuItem
            // 
            this.openProgramDirectoryToolStripMenuItem.Name = "openProgramDirectoryToolStripMenuItem";
            this.openProgramDirectoryToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.openProgramDirectoryToolStripMenuItem.Text = "Open program directory..";
            this.openProgramDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openProgramDirectoryToolStripMenuItem_Click);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(832, 191);
            this.trackBar3.Maximum = 50;
            this.trackBar3.Minimum = -50;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(298, 45);
            this.trackBar3.TabIndex = 11;
            this.trackBar3.Scroll += new System.EventHandler(this.SaturationAdjustment);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(830, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Saturation";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(931, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 39);
            this.button2.TabIndex = 14;
            this.button2.Text = "Negative";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Negative_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(931, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "Sepia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Sepia_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(931, 593);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 39);
            this.button3.TabIndex = 16;
            this.button3.Text = "Grayscale";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Grayscale_click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(951, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Filters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(724, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(768, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Web Cam";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(758, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Start";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Start_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(758, 380);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Stop";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Stop_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1137, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1137, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 20);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1137, 191);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(48, 20);
            this.textBox3.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(631, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Filter Suggestions:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(63, 510);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 42;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.recurringColorBoxClick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(634, 479);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(264, 161);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 43;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.SuggestedFilterBoxClick);
            // 
            // button17
            // 
            this.button17.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button17.Location = new System.Drawing.Point(257, 494);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(158, 42);
            this.button17.TabIndex = 44;
            this.button17.Text = "Determine Category";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.UseWaitCursor = true;
            this.button17.Click += new System.EventHandler(this.GetCategory);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(60, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Main Color";
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button18.Location = new System.Drawing.Point(1057, 506);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(90, 23);
            this.button18.TabIndex = 46;
            this.button18.Text = "Rotate 90 CW";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.Rotate90CW);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox6.Location = new System.Drawing.Point(26, 566);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(193, 20);
            this.textBox6.TabIndex = 47;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox7.Location = new System.Drawing.Point(257, 568);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(339, 20);
            this.textBox7.TabIndex = 48;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(892, 315);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 61);
            this.button6.TabIndex = 49;
            this.button6.Text = "Open Image Comparison Window";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.OpenComparison);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1209, 649);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = " Image Manipulation";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem openProgramDirectoryToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button6;
    }
}