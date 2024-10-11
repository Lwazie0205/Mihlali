using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Booked
{
    public partial class UserControl1 : UserControl
    {
        public string PdfFilePath { get; set; }
        public delegate void DownloadButtonClickedHandler(string pdfFilePath);
        public event DownloadButtonClickedHandler DownloadButtonClicked;
        public UserControl1()
        {
            InitializeComponent();
        }
        private string l1;
        public string L1
        {
            get { return l1; }
            set { l1 = value; labelText.Text = value; }
        }

        private string l2;
        public string L2
        {
            get { return l2; }
            set { l2 = value; labelAuthor.Text = value; }
        }

        private string l3;
        public string L3
        {
            get { return l3; }
            set { l3 = value; labelType.Text = value; }
        }

        private string l5;
        public string L5
        {
            get { return l5; }
            set { l5 = value; labelPdf.Text = value; }
        }

        private Image l4;
        public Image L4
        {
            get { return l4; }
            set { l4 = value; pictureBoxuc.Image = value; }
        }

        private void Descriptionbtn_Click(object sender, EventArgs e)
        {
            DisplayInfo();
        }

        private void DisplayInfo()
        {
            byte[] pdfBytes = GetPdfFromDatabase();
            string tempPath = SavePdfToTempFile(pdfBytes);
            Reading_Now frm = (Reading_Now)ParentForm;
            frm.DisplayPdfInWebBrowser(tempPath);
        }

        private byte[] GetPdfFromDatabase()
        {
            string connString = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\L3G2\Documents\Database\BOOK DATABASE.accdb");
            string query = "SELECT FilePdf FROM FILES";

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string pdfPath = (string)reader[0];
                    return File.ReadAllBytes(pdfPath);
                }
            }
            return null;
        }

        private string SavePdfToTempFile(byte[] pdfBytes)
        {
            string tempPath = Path.GetTempFileName();
            File.WriteAllBytes(tempPath,pdfBytes);
            return tempPath;
        }


        public string GetSearchText()
        {
            return labelText.Text + " " + labelAuthor.Text + " " + labelType.Text;
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
          
                    WebBrowser wb2 = new WebBrowser();
                     wb2.Url = new Uri(l5);
                   
           
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

            
    }
}
