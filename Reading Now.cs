using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Booked
{
    public partial class Reading_Now : Form
    {
        private OleDbConnection conn;
        private OleDbCommand cmd;

        public Reading_Now()
        {
            InitializeComponent();
        }

        // Event handler for download button click inside UserControl1
        private void UserControl1_DownloadClicked(object sender, EventArgs e)
        {
            UserControl1 userControl = (UserControl1)sender;
            string pdfFilePath = userControl.PdfFilePath;

            try
            {
                webBrowser1.Navigate(pdfFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading PDF: " + ex.Message);
            }
        }

        // Method to dynamically create UserControl instances based on database records
        private void CreateUserControlInstances()
        {
            try
            {
                using (conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\Database\BOOK DATABASE.accdb"))
                {
                    string query = "SELECT FilePdf FROM FILES";
                    cmd = new OleDbCommand(query, conn);
                    conn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        UserControl1 userControl = new UserControl1();
                        userControl.DownloadButtonClicked += (pdfFilePath) =>
                        {
                            webBrowser1.Navigate(pdfFilePath);
                        };
                        userControl.PdfFilePath = reader["FilePdf"].ToString();
                        flowLayoutPanel1.Controls.Add(userControl);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating user controls: " + ex.Message);
            }
        }

        // Load event to initialize connection and load controls
        private void Reading_Now_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\Database\BOOK DATABASE.accdb");
                cmd = new OleDbCommand();
                cmd.Connection = conn;

                PI();  // Load the book information
                CreateUserControlInstances();  // Create user control instances based on database records
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing form: " + ex.Message);
            }
        }

        // Method to display the PDF in a web browser control
        public void DisplayPdfInWebBrowser(string tempPath)
        {
            try
            {
                webBrowser1.Url = new Uri(tempPath);
                WebBrowser wb1 = new WebBrowser();
                flowLayoutPanel1.Controls.Add(wb1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying PDF: " + ex.Message);
            }
        }

        // Method to populate user controls with information from the database
        private void PI()
        {
            string query = "SELECT FileName, FileDescription, FileCategory, FilePic, FilePdf FROM FILES";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\Database\BOOK DATABASE.accdb"))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    OleDbDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        UserControl1 uc = new UserControl1
                        {
                            L1 = reader["FileName"].ToString(),
                            L2 = reader["FileDescription"].ToString(),
                            L3 = reader["FileCategory"].ToString(),
                            L4 = Image.FromFile(reader["FilePic"].ToString()),  // Ensure valid image path
                            L5 = reader["FilePdf"].ToString()
                        };

                        flowLayoutPanel1.Controls.Add(uc);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading book information: " + ex.Message);
            }
        }

        // Button click event to reload the book store
        private void BookStorebtn_Click(object sender, EventArgs e)
        {
            PI();  // Reload book information
        }

        // Button click event to navigate back to the main form
        private void Backbtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }
    }
}
