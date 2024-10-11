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
    public partial class Sign_Up : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;

        public Sign_Up()
        {
            InitializeComponent();
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\Database\BOOK DATABASE.accdb");
                cmd = new OleDbCommand();
                cmd.Connection = conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing the database connection: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBoxUsername.Text;
                string password = textBox6Password.Text;
                string confirmPassword = textBoxConfirmpassword.Text;

                // Password validation
                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match. Please ensure both passwords are the same.");
                    return;
                }

                conn.Open();

                // Use parameterized queries to prevent SQL injection
                string checkUserQuery = "SELECT * FROM CUSTOMERS WHERE SUUSERNAME = ? AND SUPASSWORD = ?";
                OleDbCommand cmd = new OleDbCommand(checkUserQuery, conn);
                cmd.Parameters.AddWithValue("@SUUSERNAME", username);
                cmd.Parameters.AddWithValue("@SUPASSWORD", password);

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Customer with this username and password already exists!");
                    reader.Close();
                }
                else
                {
                    reader.Close();

                    // Insert customer data using parameterized query
                    string insertQuery = "INSERT INTO CUSTOMERS (SUNAME, SUSURNAME, SUCELLPHONE, SUEMAIL, SUUSERNAME, SUPASSWORD) " +
                                         "VALUES (?, ?, ?, ?, ?, ?)";
                    OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@SUNAME", textBox1.Text);
                    insertCmd.Parameters.AddWithValue("@SUSURNAME", textBox2.Text);
                    insertCmd.Parameters.AddWithValue("@SUCELLPHONE", textBox3.Text);
                    insertCmd.Parameters.AddWithValue("@SUEMAIL", textBox4.Text);
                    insertCmd.Parameters.AddWithValue("@SUUSERNAME", username);
                    insertCmd.Parameters.AddWithValue("@SUPASSWORD", password);

                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Customer added successfully!");

                    Form1 frm1 = new Form1();
                    frm1.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed properly
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
