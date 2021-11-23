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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Profile ob = new Profile();
            if(ob == null)
            {
                ob.Parent = this;
            }
            ob.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
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
