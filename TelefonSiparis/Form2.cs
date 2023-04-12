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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Samsung Galaxy Z Fold");
            comboBox1.Items.Add("Samsung Galaxy Z Flip 3");
            comboBox1.Items.Add("Samsung Galaxy Z Flip 4");
            comboBox1.Items.Add("Samsung Galaxy Z Fold 3");


            comboBox2.Items.Add("Redmi Note 10");
            comboBox2.Items.Add("Redmi Note 9");
            comboBox2.Items.Add("Redmi 10x Pro");
            comboBox2.Items.Add("Redmi K30");


            comboBox3.Items.Add("İphone 11");
            comboBox3.Items.Add("İphone XS MAX");
            comboBox3.Items.Add("İphone 8 Plus");
            comboBox3.Items.Add("İphone 11 Pro Max");
        }

        int tutar;
        private void btnHesapla_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Samsung Galaxy Z Fold")
            {
                tutar += 5500;
                txtsiparisler.Items.Add("Samsung Galaxy Z Fold");
            }
            if (comboBox1.Text == "Samsung Galaxy Z Flip 3")
            {
                tutar += 8500;
                txtsiparisler.Items.Add("Samsung Galaxy Z Flip 3");
            }
            if (comboBox1.Text == "Samsung Galaxy Z Flip 4")
            {
                tutar += 9000;
                txtsiparisler.Items.Add("Samsung Galaxy Z Flip 4");
            }
            if (comboBox1.Text == "Samsung Galaxy Z Fold 3")
            {
                tutar += 10500;
                txtsiparisler.Items.Add("Samsung Galaxy Z Fold 3");
            }
            if (comboBox2.Text == "Redmi Note 10")
            {
                tutar += 10500;
                txtsiparisler.Items.Add("Redmi Note 10");
            }
            if (comboBox2.Text == "Redmi Note 9")
            {
                tutar += 10500;
                txtsiparisler.Items.Add("Redmi Note 9");
            }
            if (comboBox2.Text == "Redmi 10x Pro")
            {
                tutar += 10500;
                txtsiparisler.Items.Add("Redmi 10x Pro");
            }
            if (comboBox2.Text == "Redmi K30")
            {
                tutar += 10500;
                txtsiparisler.Items.Add("Redmi K30");
            }
            if (comboBox3.Text == "İphone 11")
            {
                tutar += 10500;
                txtsiparisler.Items.Add("İphone 11");
            }
            if (comboBox3.Text == "İphone XS MAX")
            {
                tutar += 10500;
                txtsiparisler.Items.Add("İphone XS MAX");
            }
            if (comboBox3.Text == "İphone 8 Plus")
            {
                tutar += 10500;
                txtsiparisler.Items.Add("İphone 8 Plus");
            }
            if (comboBox3.Text == "İphone 11 Pro Max")
            {
                tutar += 10500;
                txtsiparisler.Items.Add("İphone 11 Pro Max");
            }

            lblTutar.Text = tutar.ToString() + "TL";

            listBox1.Items.Add(Form1.AdSoyad);
            listBox2.Items.Add(Form1.TCno);
            listBox3.Items.Add(Form1.Cinsiyet);
            listBox4.Items.Add(Form1.Telno);
            listBox5.Items.Add(Form1.Adres);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secim = comboBox1.SelectedIndex;
            switch (secim)
            {
                case 0:
                    pictureBox1.ImageLocation = "C:/Users/W10/OneDrive/Masaüstü/telefonlar/s1.jpg";
                    break;

                case 1:
                    pictureBox1.ImageLocation = "C:/Users/W10/OneDrive/Masaüstü/telefonlar/s2.jpg";
                    break;

                case 2:
                    pictureBox1.ImageLocation = "C:/Users/W10/OneDrive/Masaüstü/telefonlar/s3.jpg";
                    break;

                case 3:
                    pictureBox1.ImageLocation = "C:/Users/W10/OneDrive/Masaüstü/telefonlar/s4.jpg";
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secim2 = comboBox2.SelectedIndex;
            switch (secim2)
            {
                case 0:
                    pictureBox2.ImageLocation = "C:/Users/W10/OneDrive/Masaüstü/telefonlar/r1.jpg";
                    break;

                case 1:
                    pictureBox2.ImageLocation = "C:/Users/W10/OneDrive/Masaüstü/telefonlar/r2.jpg";
                    break;

                case 2:
                    pictureBox2.ImageLocation = "C:/Users/W10/OneDrive/Masaüstü/telefonlar/r3.jpg";
                    break;

                case 3:
                    pictureBox2.ImageLocation = "C:/Users/W10/OneDrive/Masaüstü/telefonlar/r4.jpg";
                    break;
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secim3 = comboBox3.SelectedIndex;
            switch (secim3)
            {
                case 0:
                    pictureBox3.ImageLocation = "C:/Users/W10/OneDrive/Masaüstü/telefonlar/i1.jpg";
                    break;

                case 1:
                    pictureBox3.ImageLocation = "C:/Users/W10/OneDrive/Masaüstü/telefonlar/i2.jpg";
                    break;

                case 2:
                    pictureBox3.ImageLocation = "C:/Users/W10/OneDrive/Masaüstü/telefonlar/i3.jpg";
                    break;

                case 3:
                    pictureBox3.ImageLocation = "C:/Users/W10/OneDrive/Masaüstü/telefonlar/i4.jpg";
                    break;
            }
        }
    }
}
