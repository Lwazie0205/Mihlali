using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Booked
{
    public partial class CatControler : UserControl
    {
        public CatControler()
        {
            InitializeComponent();
        }
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value;labelTitle.Text= value; }
        }

        private string author;
        public string Author
        {
            get { return author; }

            set { author = value; labelAuthor.Text = value; }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; labelType.Text = value; }
        }
        private void CatControler_Load(object sender, EventArgs e)
        {

        }
    }
}
