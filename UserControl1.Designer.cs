namespace Booked
{
    partial class UserControl1
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
            this.pictureBoxuc = new System.Windows.Forms.PictureBox();
            this.labelText = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.labelPdf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxuc)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxuc
            // 
            this.pictureBoxuc.Location = new System.Drawing.Point(18, 19);
            this.pictureBoxuc.Name = "pictureBoxuc";
            this.pictureBoxuc.Size = new System.Drawing.Size(78, 89);
            this.pictureBoxuc.TabIndex = 0;
            this.pictureBoxuc.TabStop = false;
            // 
            // labelText
            // 
            this.labelText.AutoEllipsis = true;
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.Color.Transparent;
            this.labelText.Location = new System.Drawing.Point(117, 19);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(22, 21);
            this.labelText.TabIndex = 46;
            this.labelText.Text = "l1";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AllowDrop = true;
            this.labelAuthor.AutoEllipsis = true;
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.ForeColor = System.Drawing.Color.Transparent;
            this.labelAuthor.Location = new System.Drawing.Point(117, 53);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(22, 21);
            this.labelAuthor.TabIndex = 47;
            this.labelAuthor.Text = "l2";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.ForeColor = System.Drawing.Color.Transparent;
            this.labelType.Location = new System.Drawing.Point(117, 87);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(22, 21);
            this.labelType.TabIndex = 48;
            this.labelType.Text = "l3";
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.downloadButton.ForeColor = System.Drawing.Color.Transparent;
            this.downloadButton.Location = new System.Drawing.Point(462, 53);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 31);
            this.downloadButton.TabIndex = 80;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(517, 20);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(20, 20);
            this.webBrowser2.TabIndex = 81;
            this.webBrowser2.Visible = false;
            // 
            // labelPdf
            // 
            this.labelPdf.AutoSize = true;
            this.labelPdf.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPdf.ForeColor = System.Drawing.Color.Transparent;
            this.labelPdf.Location = new System.Drawing.Point(513, 97);
            this.labelPdf.Name = "labelPdf";
            this.labelPdf.Size = new System.Drawing.Size(22, 21);
            this.labelPdf.TabIndex = 82;
            this.labelPdf.Text = "l3";
            this.labelPdf.Visible = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.labelPdf);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.pictureBoxuc);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MaximumSize = new System.Drawing.Size(866, 433);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(550, 131);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxuc;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Label labelPdf;
    }
}
