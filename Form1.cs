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
    public partial class Form1 : Form
    {
        private bool passwordVisible = false;
        OleDbConnection conn;
        OleDbCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void ShowUserControl2()
        {
            UserControl2 uc2 = new UserControl2();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(uc2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\Database\BOOK DATABASE.accdb");
                cmd = new OleDbCommand();
                cmd.Connection = conn;

                // Set default text
                textBox1Username.Text = "username";
                textBox1Username.ForeColor = System.Drawing.Color.Gray;
                textBox2Password.Text = "username";
                textBox2Password.ForeColor = System.Drawing.Color.Gray;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing the database connection: " + ex.Message);
            }
        }

        private bool VerifyLogin(string username, string password)
        {
            bool loginSuccessful = false;

            try
            {
                conn.Open();
                // Use parameterized queries to prevent SQL injection
                string query = "SELECT * FROM CUSTOMERS WHERE SUUSERNAME = ? AND SUPASSWORD = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@SUUSERNAME", username);
                cmd.Parameters.AddWithValue("@SUPASSWORD", password);

                OleDbDataReader reader = cmd.ExecuteReader();
                loginSuccessful = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login verification failed: " + ex.Message);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return loginSuccessful;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox1Username.Text;
                string password = textBox2Password.Text;

                if (VerifyLogin(username, password))
                {
                    MessageBox.Show("Login successful!");
                    Reading_Now readingnow = new Reading_Now();
                    readingnow.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Emploginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error navigating to Employee login: " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ShowUserControl2();
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
                textBox2Password.PasswordChar = '\0'; //Show password
                togglebtn.Text = "Hide";
            }
            else
            {
                textBox2Password.PasswordChar = '*'; //Hide password
                togglebtn.Text = "Show";
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Contact_Us cs = new Contact_Us();
                cs.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Contact Us form: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Sign_Up su = new Sign_Up();
                su.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Sign-Up form: " + ex.Message);
            }
        }

        private void PrivacyPolicylbl_Click(object sender, EventArgs e)
        {
            try
            {
                PrivacyPolicy pp = new PrivacyPolicy();
                pp.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Privacy Policy: " + ex.Message);
            }
        }

        private void textBox1Username_Enter(object sender, EventArgs e)
        {
            if (textBox1Username.Text == "username")
            {
                textBox1Username.Text = "";  // Clear the default text
                textBox1Username.ForeColor = System.Drawing.Color.Black;  // Set text color to black
            }
        }

        private void textbox1Username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1Username.Text))
            {
                textBox1Username.Text = "username";  // Restore default text
                textBox1Username.ForeColor = System.Drawing.Color.Gray;  // Set text color to gray
            }
        }
    }
}
