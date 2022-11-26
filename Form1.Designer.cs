namespace omron
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.watbtn = new System.Windows.Forms.Button();
            this.snabtn = new System.Windows.Forms.Button();
            this.rstbtn = new System.Windows.Forms.Button();
            this.hlpbtn = new System.Windows.Forms.Button();
            this.darkbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // watbtn
            // 
            this.watbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.watbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.watbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.watbtn.Location = new System.Drawing.Point(347, 651);
            this.watbtn.Name = "watbtn";
            this.watbtn.Padding = new System.Windows.Forms.Padding(4);
            this.watbtn.Size = new System.Drawing.Size(200, 100);
            this.watbtn.TabIndex = 1;
            this.watbtn.Text = "WATER";
            this.watbtn.UseVisualStyleBackColor = true;
            // 
            // snabtn
            // 
            this.snabtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.snabtn.Location = new System.Drawing.Point(587, 651);
            this.snabtn.Name = "snabtn";
            this.snabtn.Padding = new System.Windows.Forms.Padding(4);
            this.snabtn.Size = new System.Drawing.Size(200, 100);
            this.snabtn.TabIndex = 2;
            this.snabtn.Text = "SNACK";
            this.snabtn.UseVisualStyleBackColor = true;
            // 
            // rstbtn
            // 
            this.rstbtn.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rstbtn.Location = new System.Drawing.Point(827, 651);
            this.rstbtn.Name = "rstbtn";
            this.rstbtn.Padding = new System.Windows.Forms.Padding(4);
            this.rstbtn.Size = new System.Drawing.Size(200, 100);
            this.rstbtn.TabIndex = 3;
            this.rstbtn.Text = "REST ROOM";
            this.rstbtn.UseVisualStyleBackColor = true;
            // 
            // hlpbtn
            // 
            this.hlpbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hlpbtn.Location = new System.Drawing.Point(1067, 651);
            this.hlpbtn.Name = "hlpbtn";
            this.hlpbtn.Padding = new System.Windows.Forms.Padding(4);
            this.hlpbtn.Size = new System.Drawing.Size(200, 100);
            this.hlpbtn.TabIndex = 4;
            this.hlpbtn.Text = "HELP";
            this.hlpbtn.UseVisualStyleBackColor = true;
            this.hlpbtn.Click += new System.EventHandler(this.hlpbtn_Click);
            // 
            // darkbtn
            // 
            this.darkbtn.Location = new System.Drawing.Point(1288, 861);
            this.darkbtn.Name = "darkbtn";
            this.darkbtn.Size = new System.Drawing.Size(150, 46);
            this.darkbtn.TabIndex = 5;
            this.darkbtn.Text = "Dark Mode";
            this.darkbtn.UseVisualStyleBackColor = true;
            this.darkbtn.Click += new System.EventHandler(this.darkbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(648, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 86);
            this.label1.TabIndex = 6;
            this.label1.Text = "OMRON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(693, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 71);
            this.label2.TabIndex = 7;
            this.label2.Text = "SPEED";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(347, 437);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Padding = new System.Windows.Forms.Padding(10);
            this.hScrollBar1.Size = new System.Drawing.Size(920, 70);
            this.hScrollBar1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(347, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 45);
            this.label3.TabIndex = 10;
            this.label3.Text = "LOW";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1164, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 45);
            this.label4.TabIndex = 11;
            this.label4.Text = "HIGH";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(693, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1524, 959);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.darkbtn);
            this.Controls.Add(this.hlpbtn);
            this.Controls.Add(this.rstbtn);
            this.Controls.Add(this.snabtn);
            this.Controls.Add(this.watbtn);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button watbtn;
        private Button snabtn;
        private Button rstbtn;
        private Button hlpbtn;
        private Button darkbtn;
        private Label label1;
        private Label label2;
        private HScrollBar hScrollBar1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}