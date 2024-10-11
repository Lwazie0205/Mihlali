namespace Booked
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.Emploginbtn = new System.Windows.Forms.Button();
            this.Manloginbtn = new System.Windows.Forms.Button();
            this.Hidebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Emploginbtn
            // 
            this.Emploginbtn.BackColor = System.Drawing.Color.White;
            this.Emploginbtn.ForeColor = System.Drawing.Color.Black;
            this.Emploginbtn.Image = ((System.Drawing.Image)(resources.GetObject("Emploginbtn.Image")));
            this.Emploginbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Emploginbtn.Location = new System.Drawing.Point(4, 46);
            this.Emploginbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Emploginbtn.Name = "Emploginbtn";
            this.Emploginbtn.Size = new System.Drawing.Size(185, 30);
            this.Emploginbtn.TabIndex = 25;
            this.Emploginbtn.Text = "Employee Login";
            this.Emploginbtn.UseVisualStyleBackColor = false;
            this.Emploginbtn.Click += new System.EventHandler(this.Emploginbtn_Click);
            // 
            // Manloginbtn
            // 
            this.Manloginbtn.BackColor = System.Drawing.Color.White;
            this.Manloginbtn.ForeColor = System.Drawing.Color.Black;
            this.Manloginbtn.Image = ((System.Drawing.Image)(resources.GetObject("Manloginbtn.Image")));
            this.Manloginbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Manloginbtn.Location = new System.Drawing.Point(4, 5);
            this.Manloginbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Manloginbtn.Name = "Manloginbtn";
            this.Manloginbtn.Size = new System.Drawing.Size(185, 31);
            this.Manloginbtn.TabIndex = 24;
            this.Manloginbtn.Text = "Manager Login";
            this.Manloginbtn.UseVisualStyleBackColor = false;
            this.Manloginbtn.Click += new System.EventHandler(this.Manloginbtn_Click);
            // 
            // Hidebtn
            // 
            this.Hidebtn.BackColor = System.Drawing.Color.White;
            this.Hidebtn.ForeColor = System.Drawing.Color.Black;
            this.Hidebtn.Image = ((System.Drawing.Image)(resources.GetObject("Hidebtn.Image")));
            this.Hidebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Hidebtn.Location = new System.Drawing.Point(4, 181);
            this.Hidebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Hidebtn.Name = "Hidebtn";
            this.Hidebtn.Size = new System.Drawing.Size(185, 39);
            this.Hidebtn.TabIndex = 26;
            this.Hidebtn.Text = "Back";
            this.Hidebtn.UseVisualStyleBackColor = false;
            this.Hidebtn.Click += new System.EventHandler(this.Hidebtn_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.Hidebtn);
            this.Controls.Add(this.Emploginbtn);
            this.Controls.Add(this.Manloginbtn);
            this.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(193, 536);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Emploginbtn;
        private System.Windows.Forms.Button Manloginbtn;
        private System.Windows.Forms.Button Hidebtn;
    }
}
