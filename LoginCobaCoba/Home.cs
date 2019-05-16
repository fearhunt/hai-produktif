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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            lblName.Text = Data.first_name + " " + Data.last_name;
            lblUser.Text = Data.uname;
        }

        //Point panel3

        private void close2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoadMore load = new LoadMore();
            load.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Hide();
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

        Data data = new Data();

        private void label8_Click(object sender, EventArgs e)
        {
            data.Lomba(label8.Text);
            FormLomba lomba = new FormLomba();
            this.Visible = false;
            lomba.ShowDialog();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            data.Event(label17.Text);
            FormEvent agenda = new FormEvent();
            this.Visible = false;
            agenda.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            data.Loker(label11.Text);
            LowonganKerja loker = new LowonganKerja();
            this.Visible = false;
            loker.ShowDialog();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Profile profile = new Profile();
            profile.ShowDialog();
        }
    }
}
