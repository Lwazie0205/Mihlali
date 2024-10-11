namespace Booked
{
    partial class Reading_Now
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reading_Now));
            this.label1 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BookStorebtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 45;
            this.label1.Text = "Reading Now";
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.White;
            this.Backbtn.ForeColor = System.Drawing.Color.Black;
            this.Backbtn.Image = ((System.Drawing.Image)(resources.GetObject("Backbtn.Image")));
            this.Backbtn.Location = new System.Drawing.Point(1094, 459);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(80, 39);
            this.Backbtn.TabIndex = 78;
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.BookStorebtn);
            this.panel1.Location = new System.Drawing.Point(94, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 396);
            this.panel1.TabIndex = 79;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 49);
            this.pictureBox2.TabIndex = 86;
            this.pictureBox2.TabStop = false;
            // 
            // BookStorebtn
            // 
            this.BookStorebtn.BackColor = System.Drawing.Color.White;
            this.BookStorebtn.ForeColor = System.Drawing.Color.Black;
            this.BookStorebtn.Location = new System.Drawing.Point(6, 3);
            this.BookStorebtn.Name = "BookStorebtn";
            this.BookStorebtn.Size = new System.Drawing.Size(214, 72);
            this.BookStorebtn.TabIndex = 80;
            this.BookStorebtn.Text = "Book Store";
            this.BookStorebtn.UseVisualStyleBackColor = false;
            this.BookStorebtn.Click += new System.EventHandler(this.BookStorebtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.webBrowser1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(314, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(860, 396);
            this.flowLayoutPanel1.TabIndex = 80;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(20, 20);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Visible = false;
            // 
            // Reading_Now
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1260, 513);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reading_Now";
            this.Text = "x    ";
            this.Load += new System.EventHandler(this.Reading_Now_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BookStorebtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}