using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonSiparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string TCno, AdSoyad, Telno, Adres,Cinsiyet;

        private void btnListele_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();


        }

        private void btnKaydet_MouseHover(object sender, EventArgs e)
        {
            btnKaydet.Size = new Size(80, 60);
            btnKaydet.BackColor = Color.Blue;

        }

        private void btnKaydet_MouseLeave(object sender, EventArgs e)
        {
            btnKaydet.Size = new Size(60, 50);
            btnKaydet.BackColor = Color.Green;

        }

        private void btnTemizle_MouseHover(object sender, EventArgs e)
        {
            btnTemizle.Size = new Size(80, 60);
            btnTemizle.BackColor = Color.Blue;
        }

        private void btnTemizle_MouseLeave(object sender, EventArgs e)
        {
            btnTemizle.Size = new Size(60, 50);
            btnTemizle.BackColor = Color.Green;
        }

        private void btnListele_MouseLeave(object sender, EventArgs e)
        {
            btnListele.Size = new Size(60, 50);
            btnListele.BackColor = Color.Green;
        }

        private void btnListele_MouseHover(object sender, EventArgs e)
        {
            btnListele.Size = new Size(80, 60);
            btnListele.BackColor = Color.Blue;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Telefon sipariş formuna erişmek \n için kişisel biligilerinizi girin ve \n kaydet butonuna tıklayın, daha sonra dilediğiniz \n telefonu sipariş verebilirsiniz.");
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtTC.Text = "";
            txtAd.Text = "";
            txtTel.Text = "";
            txtAdres.Text = "";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (txtTC.Text == "" && txtAd.Text == "" && txtAdres.Text == "" && txtTel.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
    
            }
            else
            {
                btnKaydet.Enabled = true;
            }
            AdSoyad = txtAd.Text.ToString();
            Telno = txtTel.Text.ToString();
            Adres = txtAdres.Text.ToString();
            TCno = txtTC.Text.ToString();
            if (txtTC.TextLength!=11)
            {
                MessageBox.Show("TC Numarası 11 haneli olmak zorunda!!!");
            }
            if (btnErkek.Checked == true)
            {
                Cinsiyet = "Erkek";
            }
            else
            {
                Cinsiyet = "Kadın";
            }
            btnListele.Enabled = true;
        }

        private void kişiselBilgiFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            btnListele.Enabled = false;
         
        }
    }
}
