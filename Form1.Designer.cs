namespace ImageEffects
{
    partial class Form1
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
            this.source = new System.Windows.Forms.PictureBox();
            this.result = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.metalicBtn = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.greenTintBtn = new System.Windows.Forms.PictureBox();
            this.blueTintBtn = new System.Windows.Forms.PictureBox();
            this.redTintBtn = new System.Windows.Forms.PictureBox();
            this.wavesBtn = new System.Windows.Forms.PictureBox();
            this.sepiaBtn = new System.Windows.Forms.PictureBox();
            this.grayscaleBtn = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.source)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metalicBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTintBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTintBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTintBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wavesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepiaBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleBtn)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // source
            // 
            this.source.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.source.Location = new System.Drawing.Point(29, 27);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(600, 500);
            this.source.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.source.TabIndex = 0;
            this.source.TabStop = false;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.result.Location = new System.Drawing.Point(738, 27);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(600, 500);
            this.result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.result.TabIndex = 1;
            this.result.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.metalicBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.greenTintBtn);
            this.panel1.Controls.Add(this.blueTintBtn);
            this.panel1.Controls.Add(this.redTintBtn);
            this.panel1.Controls.Add(this.wavesBtn);
            this.panel1.Controls.Add(this.sepiaBtn);
            this.panel1.Controls.Add(this.grayscaleBtn);
            this.panel1.Location = new System.Drawing.Point(29, 561);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 149);
            this.panel1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(832, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Metalic";
            // 
            // metalicBtn
            // 
            this.metalicBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metalicBtn.Location = new System.Drawing.Point(835, 16);
            this.metalicBtn.Name = "metalicBtn";
            this.metalicBtn.Size = new System.Drawing.Size(120, 100);
            this.metalicBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.metalicBtn.TabIndex = 12;
            this.metalicBtn.TabStop = false;
            this.metalicBtn.Click += new System.EventHandler(this.metalicBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(697, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Green Tint";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Blue Tint";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Red Tint";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Waves";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sepia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alb-Negru";
            // 
            // greenTintBtn
            // 
            this.greenTintBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greenTintBtn.Location = new System.Drawing.Point(700, 16);
            this.greenTintBtn.Name = "greenTintBtn";
            this.greenTintBtn.Size = new System.Drawing.Size(120, 100);
            this.greenTintBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.greenTintBtn.TabIndex = 5;
            this.greenTintBtn.TabStop = false;
            this.greenTintBtn.Click += new System.EventHandler(this.greenTintBtn_Click);
            // 
            // blueTintBtn
            // 
            this.blueTintBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blueTintBtn.Location = new System.Drawing.Point(565, 16);
            this.blueTintBtn.Name = "blueTintBtn";
            this.blueTintBtn.Size = new System.Drawing.Size(120, 100);
            this.blueTintBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blueTintBtn.TabIndex = 4;
            this.blueTintBtn.TabStop = false;
            this.blueTintBtn.Click += new System.EventHandler(this.glacialBtn_Click);
            // 
            // redTintBtn
            // 
            this.redTintBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redTintBtn.Location = new System.Drawing.Point(428, 16);
            this.redTintBtn.Name = "redTintBtn";
            this.redTintBtn.Size = new System.Drawing.Size(120, 100);
            this.redTintBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redTintBtn.TabIndex = 3;
            this.redTintBtn.TabStop = false;
            this.redTintBtn.Click += new System.EventHandler(this.redTintBtn_Click);
            // 
            // wavesBtn
            // 
            this.wavesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wavesBtn.Location = new System.Drawing.Point(289, 16);
            this.wavesBtn.Name = "wavesBtn";
            this.wavesBtn.Size = new System.Drawing.Size(120, 100);
            this.wavesBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wavesBtn.TabIndex = 2;
            this.wavesBtn.TabStop = false;
            this.wavesBtn.Click += new System.EventHandler(this.wavesBtn_Click);
            // 
            // sepiaBtn
            // 
            this.sepiaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sepiaBtn.Location = new System.Drawing.Point(151, 16);
            this.sepiaBtn.Name = "sepiaBtn";
            this.sepiaBtn.Size = new System.Drawing.Size(120, 100);
            this.sepiaBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sepiaBtn.TabIndex = 1;
            this.sepiaBtn.TabStop = false;
            this.sepiaBtn.Click += new System.EventHandler(this.sepiaBtn_Click);
            // 
            // grayscaleBtn
            // 
            this.grayscaleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grayscaleBtn.Location = new System.Drawing.Point(14, 16);
            this.grayscaleBtn.Name = "grayscaleBtn";
            this.grayscaleBtn.Size = new System.Drawing.Size(120, 100);
            this.grayscaleBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.grayscaleBtn.TabIndex = 0;
            this.grayscaleBtn.TabStop = false;
            this.grayscaleBtn.Click += new System.EventHandler(this.grayscaleBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.saveImageToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.aboutToolStripMenuItem.Text = "Author";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1350, 722);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.source);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.source)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metalicBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTintBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTintBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTintBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wavesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepiaBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleBtn)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox source;
        private System.Windows.Forms.PictureBox result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox greenTintBtn;
        private System.Windows.Forms.PictureBox blueTintBtn;
        private System.Windows.Forms.PictureBox redTintBtn;
        private System.Windows.Forms.PictureBox wavesBtn;
        private System.Windows.Forms.PictureBox sepiaBtn;
        private System.Windows.Forms.PictureBox grayscaleBtn;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox metalicBtn;
    }
}

