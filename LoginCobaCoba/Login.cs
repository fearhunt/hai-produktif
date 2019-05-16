using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            Application.ExitThread();
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
            if (unameBox.Text == "" || passBox.Text == "")
            {
                MessageBox.Show("Masukkan username dan password terlebih dahulu!");
            }
            else
            {
                using (var db = new DBModel())
                {
                    var query = (from akun in db.Akun where akun.Uname == unameBox.Text select akun).FirstOrDefault();
                    if (query == null) //check if query null
                    {
                        MessageBox.Show("Data tidak ada!");
                        unameBox.Text = "";
                        passBox.Text = "";
                    }
                    else if ((query.Uname == unameBox.Text) && (query.Pass == passBox.Text)) // masih error di sini buat login. coba pakai try except
                    {
                        Data data = new Data();
                        data.dataProfil(query.First_Name, query.Last_Name, query.Email, query.Phone, query.Uname);
                        this.Visible = false;       
                        Home dashboard = new Home();
                        dashboard.ShowDialog();
                    }
                    else if ((query.Uname == unameBox.Text) && (query.Pass != passBox.Text))
                    {
                        MessageBox.Show("Password yang dimasukkan salah!");
                        passBox.Text = "";
                    }
                }
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            this.Visible = false;
            Register register = new Register();
            register.ShowDialog();
        }
    }
}
    