namespace Booked
{
    partial class ManagerLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerLogin));
            this.togglebtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2Password = new System.Windows.Forms.TextBox();
            this.textBox1Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // togglebtn
            // 
            this.togglebtn.BackColor = System.Drawing.Color.Transparent;
            this.togglebtn.ForeColor = System.Drawing.Color.Black;
            this.togglebtn.Image = ((System.Drawing.Image)(resources.GetObject("togglebtn.Image")));
            this.togglebtn.Location = new System.Drawing.Point(667, 187);
            this.togglebtn.Name = "togglebtn";
            this.togglebtn.Size = new System.Drawing.Size(35, 20);
            this.togglebtn.TabIndex = 29;
            this.togglebtn.UseVisualStyleBackColor = false;
            this.togglebtn.Click += new System.EventHandler(this.togglebtn_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(708, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 20);
            this.button4.TabIndex = 28;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2Password
            // 
            this.textBox2Password.Location = new System.Drawing.Point(437, 184);
            this.textBox2Password.Name = "textBox2Password";
            this.textBox2Password.Size = new System.Drawing.Size(312, 27);
            this.textBox2Password.TabIndex = 27;
            this.textBox2Password.Text = "Password";
            this.textBox2Password.TextChanged += new System.EventHandler(this.textBox2Password_TextChanged);
            // 
            // textBox1Username
            // 
            this.textBox1Username.Location = new System.Drawing.Point(437, 151);
            this.textBox1Username.Name = "textBox1Username";
            this.textBox1Username.Size = new System.Drawing.Size(312, 27);
            this.textBox1Username.TabIndex = 26;
            this.textBox1Username.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(525, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Forgot password?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.Exitbtn.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.ForeColor = System.Drawing.Color.Black;
            this.Exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("Exitbtn.Image")));
            this.Exitbtn.Location = new System.Drawing.Point(1157, 431);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(80, 39);
            this.Exitbtn.TabIndex = 80;
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 81;
            this.label1.Text = "Manager Login";
            // 
            // ManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1244, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.togglebtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2Password);
            this.Controls.Add(this.textBox1Username);
            this.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManagerLogin";
            this.Text = "ManagerLogin";
            this.Load += new System.EventHandler(this.ManagerLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button togglebtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2Password;
        private System.Windows.Forms.TextBox textBox1Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Label label1;
    }
}