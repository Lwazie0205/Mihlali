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
    public partial class EmployeeLogin : Form
    {
        private bool passwordVisible = false;
        private OleDbConnection conn;
        private OleDbCommand cmd;

        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
        {
            string conneString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\Database\BOOK DATABASE.accdb";
            conn = new OleDbConnection(conneString);
            cmd = new OleDbCommand();
            cmd.Connection = conn;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string username = textBox1Username.Text;
            string password = textBox2Password.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password");
                return;
            }

            string query = "SELECT * FROM EMPLOYEE WHERE EMPUSERNAME = @username AND EMPPASSWORD = @password";

            try
            {
                conn.Open();
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Login successful!");
                            Employee emp = new Employee();
                            emp.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void textBox2Password_TextChanged(object sender, EventArgs e)
        {
            if (!passwordVisible)
            {
                textBox2Password.PasswordChar = '*';
            }
        }

        private void togglebtn_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            if (passwordVisible)
            {
                textBox2Password.PasswordChar = '\0'; // Show password
                togglebtn.Text = "Hide";
            }
            else
            {
                textBox2Password.PasswordChar = '*'; // Hide password
                togglebtn.Text = "Show";
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }
    }
}
