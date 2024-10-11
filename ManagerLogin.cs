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
    public partial class ManagerLogin : Form
    {
        private bool passwordVisible = false;

        public ManagerLogin()
        {
            InitializeComponent();
        }

        // Form Load event (You can initialize the connection if needed, but here it seems unnecessary)
        private void ManagerLogin_Load(object sender, EventArgs e)
        {
            // Connection initialization commented out for now, as it's handled within button click
        }

        // Login button click event
        private void button4_Click(object sender, EventArgs e)
        {
            string username = textBox1Username.Text;
            string password = textBox2Password.Text;

            // Validate input before attempting login
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Connection string to the database
            string conneString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\Database\BOOK DATABASE.accdb";
            string query = "SELECT * FROM MANAGER WHERE MANUSERNAME = @username AND MANPASSWORD = @password";

            // Using `using` blocks to ensure the connection and command are properly disposed
            using (OleDbConnection conn = new OleDbConnection(conneString))
            {
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    // Using parameterized queries to avoid SQL injection attacks
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    try
                    {
                        conn.Open();
                        OleDbDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())  // Check if any row is returned
                        {
                            MessageBox.Show("Login successful!");
                            Manager man = new Manager();
                            man.Show();
                            this.Hide();  // Hide the current form after successful login
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }

                        reader.Close();  // Ensure reader is closed
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        // Event handler for showing and hiding the password
        private void togglebtn_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;

            if (passwordVisible)
            {
                textBox2Password.PasswordChar = '\0';  // Show password
                togglebtn.Text = "Hide";
            }
            else
            {
                textBox2Password.PasswordChar = '*';  // Hide password
                togglebtn.Text = "Show";
            }
        }

        // Exit button click event to return to the main form
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }

        // Event handler to ensure password is hidden when user starts typing
        private void textBox2Password_TextChanged(object sender, EventArgs e)
        {
            if (!passwordVisible)
            {
                textBox2Password.PasswordChar = '*';
            }
        }
    }
}
