using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Sahibinden_Form
{
    public partial class Admin_UyeEkleme : Form
    {
        SqlConnection baglanti = new SqlConnection($"Server=DESKTOP-HNE43R2;Database=Sahibinden;Integrated Security=True;");
        public Admin_UyeEkleme()
        {
            InitializeComponent();
        }

        private void btn_uye_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "insert into tb_KULLANICI(AD,SOYAD,KULLANICI_ADI,EPOSTA,TELEFON,TC,SIFRE) values (@AD,@SOYAD,@KULLANICI_ADI,@EPOSTA,@TELEFON,@TC,@SIFRE)";

                SqlCommand komut = new SqlCommand(kayit, baglanti);
                
                komut.Parameters.AddWithValue("@AD", txt_uyeEkle_ad.Text);
                komut.Parameters.AddWithValue("@SOYAD", txt_uyeEkle_soyad.Text);
                komut.Parameters.AddWithValue("@KULLANICI_ADI", txt_uyeEkle_ka.Text);
                komut.Parameters.AddWithValue("@EPOSTA", txt_uyeEkle_eposta.Text);
                komut.Parameters.AddWithValue("@TELEFON", txt_uyeEkle_tel.Text);
                komut.Parameters.AddWithValue("@TC", txt_uyeEkle_tc.Text);
                komut.Parameters.AddWithValue("@SIFRE",txt_uyeEkle_sifre.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text_sifre = txt_uyeEkle_sifre.Text;
            txt_uyeEkle_sifre.Text = text_sifre;
        }

        private void txt_uyeEkle_sifre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_uyeEkle_sifre.PasswordChar = '\0';
            }
            else {
                txt_uyeEkle_sifre.PasswordChar = '*';
            }
        }
        /*private void DbConnect()
{
try
{
if (baglanti.State != ConnectionState.Open)
{ baglanti.Open(); }
}
catch { MessageBox.Show("Bağlantı Açılmadı."); }
}*/
    }
    } 
