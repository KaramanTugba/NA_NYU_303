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

namespace WndApp_2802
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConn = "Data Source=.;Initial Catalog=KitapDB;Integrated Security=True";

            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kitaplar",conn);
            SqlDataReader dr = cmd.ExecuteReader();
            string baslik = "";
            for (int i = 0; i < dr.FieldCount; i++)
                baslik += dr.GetName(i).ToUpper()+" ";
            listBox1.Items.Add(baslik);
            while (dr.Read())
            {
                string satir="";

                // listBox1.Items.Add(dr[0] + ". " + dr["KitapAdi"]);
                for (int i = 0; i < dr.FieldCount; i++)
                    satir += dr[i] + " ";
                listBox1.Items.Add(satir);
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strConn = "Data Source=.;Initial Catalog=KitapDB;Integrated Security=True";

            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Kitaplar (KitapAdi,YazarID,KategoriID) values (@ad,@yID,@kID)", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ad", textBox1.Text);
            cmd.Parameters.AddWithValue("@yID", textBox2.Text);
            cmd.Parameters.AddWithValue("@kID", textBox3.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strConn = "Data Source=.;Initial Catalog=KitapDB;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Kitaplar",strConn);
            
            //DataTable
            //DataSet: datatable lardan oluşur.10larca datatable olabilir. Veritabanı gibi davranır.memorydatabase


            DataTable dt = new DataTable();
            da.Fill(dt);

            //for(int i =0;i<dt.Rows.Count;i++)
            //{
            //    string satir = "";
            //    for(int j=0;j<dt.Columns.Count;j++)
            //    {
            //        satir += dt.Rows[i][j] + " ";
            //    }
            //    listBox1.Items.Add(satir);
            //}
            DataRow yeni = dt.NewRow();
            yeni[0] = 123;
            yeni[1] = "Serenat";

            dt.Rows.Add(yeni);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);


            da.Update(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
