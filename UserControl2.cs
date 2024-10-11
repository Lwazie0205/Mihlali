using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Booked
{
    public partial class UserControl2 : UserControl
    {
        //private bool passwordVisible = false;
        public UserControl2()
        {
            InitializeComponent();
        }
        OleDbConnection conn;
        OleDbCommand cmd;

        private void UserControl2_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\Database\BOOK DATABASE.accdb");
            cmd = new OleDbCommand();
            cmd.Connection = conn;
        }
       

        private void Manloginbtn_Click(object sender, EventArgs e)
        {
            
            ManagerLogin manlog = new ManagerLogin();
            manlog.Show();
            this.Hide();
        }

        private void Emploginbtn_Click(object sender, EventArgs e)
        {
            EmployeeLogin emplog = new EmployeeLogin();
            emplog.Show();
            this.Hide();
        }

        private void Hidebtn_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
