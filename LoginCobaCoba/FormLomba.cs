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
    public partial class FormLomba : Form
    {
        public FormLomba()
        {
            InitializeComponent();
            lblFLName.Text = Data.first_name + " " + Data.last_name;
            lblUser.Text = Data.uname;
            lblName.Text = Data.l_name;
            lblAuthDate.Text = Data.l_authdate;
            lblDesc.Text = Data.l_desc;
            lblDl.Text = Data.l_deadline;
            lblCp.Text = Data.l_contact;
            //lbl progress
            lblNote.Text = Data.l_note;

            if (lblName.Text == "Bukalapak Kreasi")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._8;
            }
            else if (lblName.Text == "Jenius Hackathon SEA")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._7;
            }
            else if (lblName.Text == "Lomba Blog Domainesia")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._10;
            }
            else if (lblName.Text == "Lomba Blog Travel Umroh")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._9;
            }
            else if (lblName.Text == "Lomba Paper #FutureIndonesia")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._12;
            }
            else if (lblName.Text == "Lomba Selfie Relaxing Moment")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._11;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
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
