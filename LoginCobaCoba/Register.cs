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
            int nomor = 0;
            string password = "";
            try
            {
                nomor = int.Parse(textBox2.Text);
            }
            
            catch(FormatException ex)
            {
                MessageBox.Show($"Nomor hanya boleh mengandung angka: '{ex}'");
            }

            if (textBox7.Text == textBox6.Text)
                password = textBox7.Text;
            else
                MessageBox.Show("Verifikasi password tidak sama!");

        }
    }
}
