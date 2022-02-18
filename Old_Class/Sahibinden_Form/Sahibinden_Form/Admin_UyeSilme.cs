using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Sahibinden_Form
{
    public partial class Admin_UyeSilme : Form
    {
        SqlConnection baglanti = new SqlConnection($"Server=DESKTOP-HNE43R2;Database=Sahibinden;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public Admin_UyeSilme()
        {
            InitializeComponent();
            ShowData();
        }

        private void UyeSilme_Load(object sender, EventArgs e)
        {

            ShowData();

        }
        public void ShowData()
        {
            adapter = new SqlDataAdapter("select * from tb_KULLANICI", baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void DeleteData()
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["AD"].Value);
            string sql = "DELETE FROM tb_KULLANICI WHERE AD=@AD";
            cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@AD",cellValue);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.Rows)  
            {
                int nbr = Convert.ToInt32(drow.Cells[0].Value);
                DeleteData();
            }
            ShowData();
        }

    }
    }
    
