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
    public partial class BorrowTheBook : Form
    {
        public BorrowTheBook()
        {
            InitializeComponent();
        }

        private void BorrowTheBook_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Book_review ob = new Book_review();
            if (ob == null)
            {
                ob.Parent = this;
            }
            ob.Show();
            this.Hide();
        }
    }
}
