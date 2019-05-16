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
    public partial class LoadMore : Form
    {
        public LoadMore()
        {
            InitializeComponent();
            lblName.Text = Data.first_name + " " + Data.last_name;
            lblUser.Text = Data.uname;
        }

        private void button22_Click(object sender, EventArgs e)
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

        private void button23_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home home = new Home();
            home.ShowDialog();
        }

        Data data = new Data();

        //
        //Lomba
        //

        private void label8_Click(object sender, EventArgs e)
        {
            data.Lomba(label8.Text);
            Lomba();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            data.Lomba(label17.Text);
            Lomba();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            data.Lomba(label11.Text);
            Lomba();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            data.Lomba(label20.Text);
            Lomba();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            data.Lomba(label14.Text);
            Lomba();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            data.Lomba(label3.Text);
            Lomba();
        }

        //
        //Loker
        //

        private void label41_Click(object sender, EventArgs e)
        {
            data.Loker(label41.Text);
            Lowker();
        }

        private void label38_Click(object sender, EventArgs e)
        {
            data.Loker(label38.Text);
            Lowker();
        }

        private void label35_Click(object sender, EventArgs e)
        {
            data.Loker(label35.Text);
            Lowker();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            data.Loker(label29.Text);
            Lowker();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            data.Loker(label26.Text);
            Lowker();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            data.Loker(label23.Text);
            Lowker();
        }

        //
        //Event
        //

        private void label61_Click(object sender, EventArgs e)
        {
            data.Event(label61.Text);
            Event();
        }

        private void label58_Click(object sender, EventArgs e)
        {
            data.Event(label58.Text);
            Event();
        }

        private void label55_Click(object sender, EventArgs e)
        {
            data.Event(label55.Text);
            Event();
        }

        private void label50_Click(object sender, EventArgs e)
        {
            data.Event(label50.Text);
            Event();
        }

        private void label47_Click(object sender, EventArgs e)
        {
            data.Event(label47.Text);
            Event();
        }

        private void label44_Click(object sender, EventArgs e)
        {
            data.Event(label44.Text);
            Event();
        }

        public void Lomba()
        {
            FormLomba lomba = new FormLomba();
            this.Visible = false;
            lomba.ShowDialog();
        }

        public void Lowker()
        {
            LowonganKerja loker = new LowonganKerja();
            this.Visible = false;
            loker.ShowDialog();
        }

        public void Event()
        {
            FormEvent agenda = new FormEvent();
            this.Visible = false;
            agenda.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home home = new Home();
            home.ShowDialog();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Profile profile = new Profile();
            profile.ShowDialog();
        }
    }
}
