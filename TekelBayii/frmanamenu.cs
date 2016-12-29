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
    public partial class franamenu : Form
    {
        public franamenu()
        {
            InitializeComponent();
        }

        private void stokekle_Click(object sender, EventArgs e)
        {
            Firma_Adi.Items.Add(comboBox1.Text);
            Ürünler.Items.Add(comboBox2.Text);
            Ürün_Boyu.Items.Add(comboBox3.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bomonti")
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox2.Items.Add("Bomonti");
                comboBox2.Items.Add("Bomonti Filtresiz");
            }
            if (comboBox1.Text == "Efes")
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();

                comboBox2.Items.Add("Efes");
                comboBox2.Items.Add("Efes Malt");
                comboBox2.Items.Add("Efes Extra");
                comboBox2.Items.Add("Efes Fıçı");
                comboBox2.Items.Add("Efes Extra Shot");
                if (comboBox1.Text == "Becks")
                {
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox2.Items.Add("Becks");


                    comboBox3.Items.Add("Becks 33cl");
                    comboBox3.Items.Add("Becks 50cl");
                }
                if (comboBox1.Text == "Kozel")
                {
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox2.Items.Add("Kozel");


                    comboBox3.Items.Add("Kozel 50cl");

                }

                if (comboBox1.Text == "Tuborg")
                {
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox2.Items.Add("Tuborg Kırmızı");
                    comboBox2.Items.Add("Tuborg Gold");
                    comboBox2.Items.Add("Tuborg Shot");


                    comboBox3.Items.Add("Tuborg Kırmızı 50cl");
                    comboBox3.Items.Add("Tuborg Gold 50cl");
                    comboBox3.Items.Add("Tuborg Shot 15cl");


                }
                if (comboBox1.Text == "Samuel Adams")
                {
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox2.Items.Add("Samuel Adams");



                    comboBox3.Items.Add("Samuel Adams 50cl");



                }
                if (comboBox1.Text == "Duwell")
                {
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox2.Items.Add("Duwell");



                    comboBox3.Items.Add("Duwell 50cl");



                }
                if (comboBox1.Text == "Guinness")
                {
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    comboBox2.Items.Add("Guinness");



                    comboBox3.Items.Add("Guinness 50cl");



                }
                //Bomonti
                //Efes
                //Efes Malt
                //Efes Extra
                //Efes Extra Shot
                //Becks
                //Kozel
                //Tuborg Kırmızı
                //Tuborg Gold
                //Tuborg Shot
                //Samuel Adams
                //Duwell
                //Guinness







            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    progressBar1.Value += 10;
                    label5.Text = progressBar1.Value.ToString();
                }
                if (radioButton2.Checked == true)
                {
                    progressBar2.Value += 10;
                    label6.Text = progressBar2.Value.ToString();
                }
                if (radioButton3.Checked == true)
                {
                    progressBar3.Value += 10;
                    label7.Text = progressBar3.Value.ToString();
                }
                if (radioButton4.Checked == true)
                {
                    progressBar4.Value += 10;
                    label8.Text = progressBar4.Value.ToString();
                }
                if (radioButton5.Checked == true)
                {
                    progressBar5.Value += 10;
                    label9.Text = progressBar5.Value.ToString();
                }
                if (radioButton6.Checked == true)
                {
                    progressBar6.Value += 10;
                    label10.Text = progressBar6.Value.ToString();
                }
                if (radioButton7.Checked == true)
                {
                    progressBar7.Value += 10;
                    label11.Text = progressBar7.Value.ToString();
                }
                if (radioButton8.Checked == true)
                {
                    progressBar8.Value += 10;
                    label12.Text = progressBar8.Value.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Oylama Kapanmıştır..");
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Ürün Ad : "+comboBox4.Text);
            listBox1.Items.Add("Ürün Birim Fyat : " + textBox1.Text);
            listBox1.Items.Add("Ürün Adedi : " + textBox2.Text);
            listBox1.Items.Add("Satılacak Yer : " + comboBox5.Text);
            listBox1.Items.Add("Toplam Tutar : " + textBox3.Text+"₺");
            listBox1.Items.Add("Satış İşlemi Tamamlanmış Ücret Ödenmiştir..");
            listBox1.Items.Add("");
            listBox1.Items.Add("");




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt16(textBox1.Text);
                int b = Convert.ToInt16(textBox2.Text);
                textBox3.Text = (a * b).ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Sayı Değer Giriniz", "HATA");
            }
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem == "Bomonti") textBox1.Text = "5";
            if (comboBox4.SelectedItem == "Efes") textBox1.Text = "6";
            if (comboBox4.SelectedItem == "Becks") textBox1.Text = "9";
            if (comboBox4.SelectedItem == "Kozel") textBox1.Text = "4";
            if (comboBox4.SelectedItem == "Duwell") textBox1.Text = "8";
            if (comboBox4.SelectedItem == "Tuborg") textBox1.Text = "7";
            if (comboBox4.SelectedItem == "Guinness") textBox1.Text = "10";
            if (comboBox4.SelectedItem == "Samuel Adams") textBox1.Text = "11";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Efes")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Efes 33cl");
                comboBox3.Items.Add("Efes 50cl");
            }
            if (comboBox2.Text == "Efes Malt")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Efes Malt 33cl");
                comboBox3.Items.Add("Efes Malt 50cl");
            }
            if (comboBox2.Text == "Efes Extra")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Efes Extra 33cl");
                comboBox3.Items.Add("Efes Extra 50cl");
            }
            if (comboBox2.Text == "Efes Fıçı")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Efes Fıçı 33cl");
                comboBox3.Items.Add("Efes Fıçı 50cl");
            }
            if (comboBox2.Text == "Efes Extra Shot")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Efes Extra Shot 15cl");
            }
            if (comboBox2.Text == "Bomonti Filtresiz")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Bomonti Filtresiz 33cl");
                comboBox3.Items.Add("Bomonti Filtresiz 50cl");
            }
            if (comboBox2.Text == "Bomonti")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Bomonti 33cl");
                comboBox3.Items.Add("Bomonti 50cl");
            }
        }
    }
}
