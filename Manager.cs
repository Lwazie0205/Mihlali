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
    public partial class Manager : Form
    {
        private OleDbDataAdapter adapter;
        private DataTable dataTable;
        private OleDbConnection conn;
        private OleDbCommand cmd;

        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\Database\BOOK DATABASE.accdb";
            conn = new OleDbConnection(connString);
            cmd = new OleDbCommand();
            cmd.Connection = conn;
            // Load data into DataGridView when form loads
            FillDataGridView("SELECT * FROM FILES", "Books");
        }

        // Method to fill DataGridView
        private void FillDataGridView(string query, string tabName)
        {
            try
            {
                adapter = new OleDbDataAdapter(query, conn);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                switch (tabName)
                {
                    case "Books":
                        dataGridView1.DataSource = dataTable;
                        break;
                    case "Employees":
                        dataGridView2.DataSource = dataTable;
                        break;
                    case "Customers":
                        dataGridView3.DataSource = dataTable;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Method to handle Search button click
        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string searchQuery = searchTextBox.Text;
            string selectedTab = tabControl1.SelectedTab.Text;
            string query = "";

            switch (selectedTab)
            {
                case "Books":
                    query = "SELECT * FROM FILES WHERE FileName LIKE @search OR FileDescription LIKE @search OR FileCategory LIKE @search";
                    break;
                case "Employees":
                    query = "SELECT * FROM EMPLOYEE WHERE EMPNAME LIKE @search OR EMPSURNAME LIKE @search OR EMPCELLPHONE LIKE @search";
                    break;
                case "Customers":
                    query = "SELECT * FROM CUSTOMERS WHERE SUNAME LIKE @search OR SUSURNAME LIKE @search OR SUCELLPHONE LIKE @search";
                    break;
            }
            ExecuteSearch(query, searchQuery, selectedTab);
        }

        // Method to execute search query
        private void ExecuteSearch(string query, string searchQuery, string tabName)
        {
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");

                try
                {
                    conn.Open();
                    adapter = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    switch (tabName)
                    {
                        case "Books":
                            dataGridView1.DataSource = dt;
                            break;
                        case "Employees":
                            dataGridView2.DataSource = dt;
                            break;
                        case "Customers":
                            dataGridView3.DataSource = dt;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        // Save customer data
        private void Savebttn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO CUSTOMERS (SUNAME, SUSURNAME, SUCELLPHONE, SUEMAIL) VALUES (@fname, @lname, @phone, @email)";
            ExecuteNonQuery(query, new[] { textBox23FNAME.Text, textBox22LNAME.Text, textBox21PHONE.Text, textBox19EEMAIL.Text });
        }

        // Delete customer data
        private void Deletebttn_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM CUSTOMERS WHERE SUNAME = @fname";
            ExecuteNonQuery(query, new[] { textBox23FNAME.Text });
        }

        // Update customer data
        private void Refreshbttn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE CUSTOMERS SET SUNAME = @fname, SUSURNAME = @lname, SUCELLPHONE = @phone, SUEMAIL = @email WHERE SUNAME = @fname";
            ExecuteNonQuery(query, new[] { textBox23FNAME.Text, textBox22LNAME.Text, textBox21PHONE.Text, textBox19EEMAIL.Text });
        }

        // Execute insert, update, delete queries
        private void ExecuteNonQuery(string query, string[] parameters)
        {
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@fname", parameters[0]);
                    if (parameters.Length > 1)
                    {
                        cmd.Parameters.AddWithValue("@lname", parameters[1]);
                        cmd.Parameters.AddWithValue("@phone", parameters[2]);
                        cmd.Parameters.AddWithValue("@email", parameters[3]);
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Operation successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        // View customer data
        private void Viewbttn_Click(object sender, EventArgs e)
        {
            FillDataGridView("SELECT * FROM CUSTOMERS", "Customers");
        }

        // Add a new book
        private void button8_Click(object sender, EventArgs e)
        {
            string checkQuery = "SELECT * FROM FILES WHERE FileName = @FileName";
            using (OleDbCommand cmd = new OleDbCommand(checkQuery, conn))
            {
                cmd.Parameters.AddWithValue("@FileName", textBox5Title.Text);
                conn.Open();

                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("File already exists!");
                }
                else
                {
                    reader.Close();
                    string insertQuery = "INSERT INTO FILES (FileName, FileDescription, FileCategory, FilePdf, FilePic) VALUES (@FileName, @FileDescription, @FileCategory, @FilePdf, @FilePic)";
                    ExecuteNonQuery(insertQuery, new[] { textBox5Title.Text, textBox6Author.Text, comboBox1Categories.Text, textBox7Quantity.Text, textBox8Size.Text });
                }
                conn.Close();
            }
        }

        // Other methods (Delete file, Update file, View file, etc.) can be refactored similarly...
    }
}
