namespace Booked
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1Username = new System.Windows.Forms.TextBox();
            this.textBox2Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.togglebtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.PrivacyPolicylbl = new System.Windows.Forms.Label();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1Username
            // 
            this.textBox1Username.Location = new System.Drawing.Point(469, 162);
            this.textBox1Username.Name = "textBox1Username";
            this.textBox1Username.Size = new System.Drawing.Size(344, 27);
            this.textBox1Username.TabIndex = 0;
            this.textBox1Username.Text = "Username";
            // 
            // textBox2Password
            // 
            this.textBox2Password.Location = new System.Drawing.Point(469, 195);
            this.textBox2Password.Name = "textBox2Password";
            this.textBox2Password.Size = new System.Drawing.Size(344, 27);
            this.textBox2Password.TabIndex = 1;
            this.textBox2Password.Text = "Password";
            this.textBox2Password.TextChanged += new System.EventHandler(this.textBox2Password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(575, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Forgot password?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(579, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "---------------or---------------";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(513, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(769, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 20);
            this.button4.TabIndex = 13;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Read Me";
            // 
            // togglebtn
            // 
            this.togglebtn.BackColor = System.Drawing.Color.Transparent;
            this.togglebtn.ForeColor = System.Drawing.Color.Transparent;
            this.togglebtn.Image = ((System.Drawing.Image)(resources.GetObject("togglebtn.Image")));
            this.togglebtn.Location = new System.Drawing.Point(728, 199);
            this.togglebtn.Name = "togglebtn";
            this.togglebtn.Size = new System.Drawing.Size(35, 20);
            this.togglebtn.TabIndex = 25;
            this.togglebtn.UseVisualStyleBackColor = false;
            this.togglebtn.Click += new System.EventHandler(this.togglebtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(193, 386);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(13, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Menu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PrivacyPolicylbl
            // 
            this.PrivacyPolicylbl.AutoSize = true;
            this.PrivacyPolicylbl.ForeColor = System.Drawing.Color.Transparent;
            this.PrivacyPolicylbl.Location = new System.Drawing.Point(14, 483);
            this.PrivacyPolicylbl.Name = "PrivacyPolicylbl";
            this.PrivacyPolicylbl.Size = new System.Drawing.Size(94, 21);
            this.PrivacyPolicylbl.TabIndex = 29;
            this.PrivacyPolicylbl.Text = "Privacy Policy";
            this.PrivacyPolicylbl.Click += new System.EventHandler(this.PrivacyPolicylbl_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.White;
            this.Exitbtn.ForeColor = System.Drawing.Color.Black;
            this.Exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("Exitbtn.Image")));
            this.Exitbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exitbtn.Location = new System.Drawing.Point(1113, 460);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(135, 41);
            this.Exitbtn.TabIndex = 78;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(1058, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(190, 41);
            this.button9.TabIndex = 79;
            this.button9.Text = "Contact Us";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(428, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 27);
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1260, 513);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.PrivacyPolicylbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.togglebtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2Password);
            this.Controls.Add(this.textBox1Username);
            this.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1Username;
        private System.Windows.Forms.TextBox textBox2Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button togglebtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PrivacyPolicylbl;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

