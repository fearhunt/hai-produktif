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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                long nomor = 0;
                string password = "";
                Boolean progress = true;
                try
                {
                    nomor = long.Parse(textBox2.Text);
                }

                catch (FormatException)
                {
                    MessageBox.Show($"Nomor hanya boleh mengandung angka!");
                    progress = false;
                }

                if (textBox7.Text == textBox6.Text)
                    password = textBox7.Text;
                else
                {
                    MessageBox.Show("Verifikasi password tidak sama!");
                    progress = false;
                }

                try
                {
                    var addr = new System.Net.Mail.MailAddress(textBox4.Text);
                }
                catch
                {
                    MessageBox.Show("Format E-mail tidak benar!");
                    progress = false;
                }

                if(progress==true)
                {
                    TambahData(nomor, password);
                    this.Visible = false;
                    Login login = new Login();
                    login.ShowDialog();
                }
                else
                {
                    this.Close();
                    Register register = new Register();
                    register.ShowDialog();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login login = new Login();
            login.ShowDialog();
        }

        private void TambahData(long Nomor, string Passsword)
        {
            using (var db = new DBModel())
            {
                Akun newAkun = new Akun
                {
                    First_Name = textBox1.Text,
                    Last_Name = textBox3.Text,
                    Phone = Nomor.ToString(),
                    Email = textBox4.Text,
                    Uname = textBox5.Text,
                    Pass = Passsword,
                };
                db.Akun.Add(newAkun);
                db.SaveChanges();
                MessageBox.Show("Register Berhasil!");
            }
        }
    }
}
