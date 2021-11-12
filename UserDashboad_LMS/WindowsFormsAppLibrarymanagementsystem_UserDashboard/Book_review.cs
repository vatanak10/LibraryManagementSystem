using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLibrarymanagementsystem_UserDashboard
{
    public partial class Book_review : Form
    {
        public Book_review()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            if (ob == null)
            {
                ob.Parent = this;
            }
            ob.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BorrowTheBook ob = new BorrowTheBook();
            if (ob == null)
            {
                ob.Parent = this;
            }
            ob.Show();
            this.Hide();
        }
    }
}
