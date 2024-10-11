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
    public partial class Employee : Form
    {
        private OleDbDataAdapter adapter;
        private DataTable dataTable;
        public Employee()
        {
            InitializeComponent();
        }
        OleDbConnection conn;
        OleDbCommand cmd;

        private void Employee_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\Database\BOOK DATABASE.accdb");
                cmd = new OleDbCommand();
                cmd.Connection = conn;
                // Load data into DataGridView when form loads
                string query = "SELECT * FROM FILES";
                FillDataGridView(query, "Books");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
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
                MessageBox.Show("Error loading data into DataGridView: " + ex.Message);
            }
        }

        // Method to search books
        private void SearchBooks(string SearchQuery)
        {
            try
            {
                string query = "SELECT * FROM FILES WHERE FileName LIKE @Search OR FileDescription LIKE @Search OR FileCategory LIKE @Search";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Search", "%" + SearchQuery + "%");
                FillDataGridView(query, "Books");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching books: " + ex.Message);
            }
        }

        // Method to add a new file
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Check if the file already exists
                cmd.CommandText = "SELECT * FROM FILES WHERE FileName = @FileName";
                cmd.Parameters.AddWithValue("@FileName", textBox5Title.Text);
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("File already exists!");
                }
                else
                {
                    reader.Close();
                    cmd.CommandText = "INSERT INTO FILES (FileName, FileDescription, FileCategory, FilePdf, FilePic) VALUES (@FileName, @FileDescription, @FileCategory, @FilePdf, @FilePic)";
                    cmd.Parameters.Clear(); // Clear previous parameters
                    cmd.Parameters.AddWithValue("@FileName", textBox5Title.Text);
                    cmd.Parameters.AddWithValue("@FileDescription", textBox6Author.Text);
                    cmd.Parameters.AddWithValue("@FileCategory", comboBox1Categories.Text);
                    cmd.Parameters.AddWithValue("@FilePdf", textBox7Quantity.Text);
                    cmd.Parameters.AddWithValue("@FilePic", textBox8Size.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("File added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding file: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Method to delete a file
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM FILES WHERE FileName = @FileName";
                cmd.Parameters.AddWithValue("@FileName", textBox5Title.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("File deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting file: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Method to update a file
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE FILES SET FileName = @FileName, FileDescription = @FileDescription, FileCategory = @FileCategory, FilePdf = @FilePdf, FilePic = @FilePic WHERE FileName = @FileName";
                cmd.Parameters.AddWithValue("@FileName", textBox5Title.Text);
                cmd.Parameters.AddWithValue("@FileDescription", textBox6Author.Text);
                cmd.Parameters.AddWithValue("@FileCategory", comboBox1Categories.Text);
                cmd.Parameters.AddWithValue("@FilePdf", textBox7Quantity.Text);
                cmd.Parameters.AddWithValue("@FilePic", textBox8Size.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("File updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating file: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Method to refresh data in the DataGridView
        private void Refreshbttn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM FILES";
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Other event handlers with similar try-catch and error handling as shown above...
    }
}
