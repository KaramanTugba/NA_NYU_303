using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ders13_Form_Ado_Net
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti=new SqlConnection($"Server=DESKTOP-HNE43R2;Database=DB_test;Integrated Security=True;");
    
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand insertCommand = new SqlCommand("SP_OgrenciEkle", baglanti);
            insertCommand.CommandType = CommandType.StoredProcedure;
            insertCommand.Parameters.AddWithValue("@AD", txt_Ad.Text);
            insertCommand.Parameters.AddWithValue("@SOYAD", txt_Soyad.Text);
            insertCommand.Parameters.AddWithValue("@TEL", txt_Tel.Text);
            insertCommand.Parameters.AddWithValue("@TC", txt_TC.Text);
            DbConnect();
            //Eklemeden sonra ilk satırın ilk kolonunu getirir
            int SonID = Convert.ToInt32(insertCommand.ExecuteScalar());
            MessageBox.Show(SonID.ToString());
            DbDisconnect();

        }
        private void DbConnect()
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                { baglanti.Open(); }
            }
            catch { MessageBox.Show("bağlantı açma başarısız."); }
        }
        private void DbDisconnect()
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                { baglanti.Close(); }
            }
            catch { MessageBox.Show("bağlantı kapatma başarısız."); }
        }
        private string GetOgrenciAd(int ID)
        {
            DbConnect();
            SqlCommand sorgu = new SqlCommand($"select Concat(AD,' ',SOYAD) as adSoyad From tb_ogrenci where ID={ID};", baglanti);
            SqlDataReader dr = sorgu.ExecuteReader();
            string adSoyad = "";
            while (dr.Read())
            {
                adSoyad = dr.GetString(0);
            }
            DbDisconnect();
            return adSoyad;
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int silinecekID = int.Parse(cmb_Sil_Liste.SelectedValue.ToString());
            SqlCommand silCommand = new SqlCommand("DELETE FROM tb_ogrenci WHERE ID=@id;", baglanti);
            silCommand.Parameters.Clear();
            silCommand.Parameters.AddWithValue("@ID",silinecekID);

            string adSoyad = GetOgrenciAd(silinecekID);
            DialogResult cevap = MessageBox.Show(adSoyad + $"Silmek istediğinizden emin misiniz?", "SİLME ONAYI", MessageBoxButtons.YesNo);
                }

        private void Form1_Load(object sender, EventArgs e)
        {
            OgrenciyiListeleUpdate();
            //sqldataadapter tablo olarak veri çekmemizi sağlar
        }
        private void OgrenciyiListeleUpdate()
        {
            //sqldataadapter tablo olarak veri çekmemizi sağlar.
            SqlDataAdapter adpOgrenci = new SqlDataAdapter("SELECT ID,concat(AD,' ',SOYAD) as [AD SOYAD],TEL as TELEFON,TC AS TC,AD,SOYAD FROM tb_ogrenci order by AD,SOYAD)", baglanti);

            DataTable dtOgrenci = new DataTable();
            adpOgrenci.Fill(dtOgrenci);
                }
    }
}
