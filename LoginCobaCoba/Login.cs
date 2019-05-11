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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            garis1.BackColor = ColorTranslator.FromHtml("#af4ef1");
            garis2.BackColor = ColorTranslator.FromHtml("#272727");
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            garis1.BackColor = ColorTranslator.FromHtml("#272727");
            garis2.BackColor = ColorTranslator.FromHtml("#af4ef1");
        }

        private void close_MouseHover(object sender, EventArgs e)
        {
            close.ForeColor = ColorTranslator.FromHtml("#272727");
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = ColorTranslator.FromHtml("#858585");
        }

        private void roundButton1_MouseHover(object sender, EventArgs e)
        {
            roundButton1.BackColor = ColorTranslator.FromHtml("#af4ef1");
        }

        private void roundButton1_MouseLeave(object sender, EventArgs e)
        {
            roundButton1.BackColor = ColorTranslator.FromHtml("#272727");
        }

        private void lupapass_MouseHover(object sender, EventArgs e)
        {
            lupapass.ForeColor = ColorTranslator.FromHtml("#272727");
        }

        private void lupapass_MouseLeave(object sender, EventArgs e)
        {
            lupapass.ForeColor = ColorTranslator.FromHtml("#858585");
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = ColorTranslator.FromHtml("#272727");
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = ColorTranslator.FromHtml("#858585");
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Masukkan username dan password terlebih dahulu!");
            }
            else
            {
                using (var db = new AkunModel())
                {
                    var query = from akun in db.Akun where akun.Uname == textBox1.Text select akun;
                    if (query != null) // masih error di sini buat login. coba pakai try except
                    {
                        this.Visible = false;
                        fearhunt_coba dashboard = new fearhunt_coba();
                        dashboard.ShowDialog();
                    }
                    else if (query == null)
                    {
                        MessageBox.Show("Data tidak ada!");
                    }
                }
            }
        }
    }
}
    