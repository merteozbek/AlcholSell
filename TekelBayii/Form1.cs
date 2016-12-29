using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekelBayii
{
    public partial class tklbayigiris : Form
    {
        public tklbayigiris()
        {
            InitializeComponent();
        }
        public static string _kullanici;
        public static string _seviye;
        private void txtcikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            {
                string kadi = "sa";
                string sifre = "1";
                int seviye = 2;
                string kad = txtkadi.Text;
                string sif = txtsifre.Text;
                if (kadi == kad && sifre == sif)
                {
                    //Buradaki Komutu Çalıştırır
                    _kullanici = kad;
                    _seviye = seviye.ToString();
                    franamenu frmAnamenu = new franamenu();
                    frmAnamenu.Show();
                    this.Visible = false;
                }
                else
                {

                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtkadi.Clear();
                    txtsifre.Clear();


                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
