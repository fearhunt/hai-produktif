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
    public partial class FormEvent : Form
    {
        public FormEvent()
        {
            InitializeComponent();
            lblFLName.Text = Data.first_name + " " + Data.last_name;
            lblUser.Text = Data.uname;
            lblName.Text = Data.e_name;
            lblAuthDate.Text = Data.e_authdate;
            lblDesc.Text = Data.e_desc;
            lblDate.Text = Data.e_date;
            lblStatus.Text = Data.e_status;
            lblNote.Text = Data.e_note;

            if (lblName.Text == "Entrepreneur Day")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._5;
            }
            else if (lblName.Text == "Find IT!")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._1;
            }
            else if (lblName.Text == "Journartlism")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._6;
            }
            else if (lblName.Text == "NESCO")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._2;
            }
            else if (lblName.Text == "Public Speaking Training")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._4;
            }
            else if (lblName.Text == "Technocorner")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home home = new Home();
            home.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Skill skill = new Skill();
            skill.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Tasks task = new Tasks();
            task.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoadMore load = new LoadMore();
            load.ShowDialog();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Profile profile = new Profile();
            profile.ShowDialog();
        }
    }
}
