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
    public partial class LowonganKerja : Form
    {
        public LowonganKerja()
        {
            InitializeComponent();
            lblFLName.Text = Data.first_name + " " + Data.last_name;
            lblUser.Text = Data.uname;
            lblName.Text = Data.lk_name;
            lblAuthDate.Text = Data.lk_authdate;
            lblDesc.Text = Data.lk_desc;
            lblCriteria.Text = Data.lk_criteria;
            lblStatus.Text = Data.lk_status;
            lblApplied.Text = Data.lk_dateapplied;
            lblNote.Text = Data.lk_note;

            if (lblName.Text == "Export Import Officer")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._13;
            }
            else if (lblName.Text == "Financial Specialist")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._14;
            }
            else if (lblName.Text == "Junior Associate Accountant")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._15;
            }
            else if (lblName.Text == "Junior Software Engineering Traveloka")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._18;
            }
            else if (lblName.Text == "Senior Data Scientist Bukalapak")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._16;
            }
            else if (lblName.Text == "Staff IT (Maintain Core System)")
            {
                pictureBox1.BackgroundImage = global::LoginCobaCoba.Properties.Resources._17;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
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
