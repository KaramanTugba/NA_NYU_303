using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_09_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            try
            {
                textBox1.Text = textBox1.Text.Replace(".",",");
                textBox2.Text = textBox2.Text.Replace(".", ",");
                toplam = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
                textBox3.Text = toplam.ToString("########.##");
                listBox1.Items.Add(textBox1.Text + "+" + textBox2.Text + "=" + toplam);
            }
            catch{
                textBox3.Text = "Geçersiz Sayı";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double carpim = 0;
            try
            {
                textBox1.Text = textBox1.Text.Replace(".", ",");
                textBox2.Text = textBox2.Text.Replace(".", ",");
                carpim = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
                textBox3.Text = carpim.ToString("########.##");
                listBox1.Items.Add(textBox1.Text + "*" + textBox2.Text + "=" + carpim);
            }
            catch
            {
                textBox3.Text = "Geçersiz Sayı";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double cikarma = 0;
            try
            {
                textBox1.Text = textBox1.Text.Replace(".", ",");
                textBox2.Text = textBox2.Text.Replace(".", ",");
                cikarma = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
                textBox3.Text = cikarma.ToString("########.##");
                listBox1.Items.Add(textBox1.Text + "-" + textBox2.Text + "=" + cikarma);
            }
            catch
            {
                textBox3.Text = "Geçersiz Sayı";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double bolme = 0;
            try
            {
                if (textBox2.Text == "0")
                    textBox3.Text = "2.sayı 0 olamaz.";
                else
                {
                    textBox1.Text = textBox1.Text.Replace(".", ",");
                    textBox2.Text = textBox2.Text.Replace(".", ",");
                    bolme = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
                    textBox3.Text = bolme.ToString("########.##");
                    listBox1.Items.Add(textBox1.Text + "/" + textBox2.Text + "=" + bolme);
                }
            }
            catch
            {
                textBox3.Text = "Geçersiz Sayı";
            }
        }
    }
}
