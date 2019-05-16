using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginCobaCoba
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            label5.Text = Data.first_name + " " + Data.last_name;
            label6.Text = Data.uname;
            label3.Text = label5.Text;
            label4.Text = Data.Phone;
            label7.Text = Data.Email;
            label10.Text = label6.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home home = new Home();
            home.ShowDialog();
        }
    }
}
