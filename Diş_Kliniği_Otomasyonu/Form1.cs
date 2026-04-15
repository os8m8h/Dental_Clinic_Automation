using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diş_Kliniği_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Admin.Text = "";
            Password.Text = "";
        }

        private void LoginTb_Click(object sender, EventArgs e)
        {
            if(Admin.Text==" " && Password.Text==" ")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else if (Admin.Text=="Admin" && Password.Text=="000000")
            {
                Anasayfa ana = new Anasayfa();
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen Doğru Kullancı Adı veya Şifre Giriniz");
            }
        }
    }
}
