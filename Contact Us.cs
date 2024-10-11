using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Booked
{
    public partial class Contact_Us : Form
    {
        public Contact_Us()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string message = textBoxMessage.Text;

            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            try
            {
                // Create a connection string
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\Database\BOOK DATABASE.accdb";

                // Create a new OleDb connection
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // Create a new OleDb Command with a parameterized query
                    string query = "INSERT INTO CONTACTUS (ContactUsUsername, ContactUsPassword, ContactUsMessage) VALUES (@ContactUsUsername, @ContactUsPassword, @ContactUsMessage)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        // Add parameters to the command
                        cmd.Parameters.AddWithValue("@ContactUsUsername", username);
                        cmd.Parameters.AddWithValue("@ContactUsPassword", password);
                        cmd.Parameters.AddWithValue("@ContactUsMessage", message);

                        // Execute the command
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thank you for contacting us! Your message has been saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving message: " + ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }
    }
}
