namespace Booked
{
    partial class EmployeeLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeLogin));
            this.togglebtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2Password = new System.Windows.Forms.TextBox();
            this.textBox1Username = new System.Windows.Forms.TextBox();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // togglebtn
            // 
            this.togglebtn.BackColor = System.Drawing.Color.Transparent;
            this.togglebtn.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.togglebtn.ForeColor = System.Drawing.Color.Black;
            this.togglebtn.Image = ((System.Drawing.Image)(resources.GetObject("togglebtn.Image")));
            this.togglebtn.Location = new System.Drawing.Point(688, 204);
            this.togglebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.togglebtn.Name = "togglebtn";
            this.togglebtn.Size = new System.Drawing.Size(35, 20);
            this.togglebtn.TabIndex = 32;
            this.togglebtn.UseVisualStyleBackColor = false;
            this.togglebtn.Click += new System.EventHandler(this.togglebtn_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(728, 204);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 20);
            this.button4.TabIndex = 31;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2Password
            // 
            this.textBox2Password.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2Password.Location = new System.Drawing.Point(457, 200);
            this.textBox2Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2Password.Name = "textBox2Password";
            this.textBox2Password.Size = new System.Drawing.Size(312, 27);
            this.textBox2Password.TabIndex = 27;
            this.textBox2Password.Text = "Password";
            this.textBox2Password.TextChanged += new System.EventHandler(this.textBox2Password_TextChanged);
            // 
            // textBox1Username
            // 
            this.textBox1Username.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1Username.Location = new System.Drawing.Point(457, 163);
            this.textBox1Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1Username.Name = "textBox1Username";
            this.textBox1Username.Size = new System.Drawing.Size(312, 27);
            this.textBox1Username.TabIndex = 26;
            this.textBox1Username.Text = "Username";
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Exitbtn.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.ForeColor = System.Drawing.Color.Transparent;
            this.Exitbtn.Location = new System.Drawing.Point(1736, 696);
            this.Exitbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(112, 50);
            this.Exitbtn.TabIndex = 79;
            this.Exitbtn.Text = "Back";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 80;
            this.label1.Text = "Employee Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(562, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 81;
            this.label2.Text = "Forgot password?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1152, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 39);
            this.button1.TabIndex = 82;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1244, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.togglebtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2Password);
            this.Controls.Add(this.textBox1Username);
            this.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployeeLogin";
            this.Text = "EmployeeLogin";
            this.Load += new System.EventHandler(this.EmployeeLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button togglebtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2Password;
        private System.Windows.Forms.TextBox textBox1Username;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}