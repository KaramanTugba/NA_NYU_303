using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_CF_MF.DAL;
using EF_CF_MF.Model;
namespace EF_CF_MF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FilmDB db = new FilmDB();
            dataGridView1.DataSource = db.Filmler.ToList();
        }

        private void btnLazy_Click(object sender, EventArgs e)
        {
            FilmDB db = new FilmDB();
            //var liste = from f in db.Filmler
            //            select new { f.FilmID, AD = f.FilmAD, f.Kategori.KategoriAD, f.Yonetmen.YonetmenAD };
            var liste = db.Filmler.ToList();
            dataGridView1.DataSource = liste.ToList();
        }

        private void btnEager_Click(object sender, EventArgs e)
        {
            //Model de Navigation prop. onunde "virtual"olup olmamasına gore calışması değişir
            FilmDB db = new FilmDB();
            var liste = db.Filmler.Include("Kategori").Include("Yonetmen").ToList();
            dataGridView1.DataSource = liste.ToList();
        
        
        }
        FilmDB db = new FilmDB();
        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            db.Kategoriler.Add(new Kategori { KategoriAD = "Animasyon" });
            db.SaveChanges();
        }

        private void btnFilmAra_Click(object sender, EventArgs e)
        {
            var film = db.Filmler.Find(1);
            var film2 = db.Filmler.Where(f => f.FilmID == 1).SingleOrDefault();
        }

        private void btnBulSil_Click(object sender, EventArgs e)
        {
            Kategori kat= db.Kategoriler.Find(4);
            db.Kategoriler.Remove(kat);
            db.SaveChanges();
        }

        private void btnBulGuncelle_Click(object sender, EventArgs e)
        {
            Kategori kat = db.Kategoriler.Find(3);
            db.Entry<Kategori>(kat).State = System.Data.Entity.EntityState.Modified;
            kat.KategoriAD = "Eğlence";
            db.SaveChanges();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strAra = textBox1.Text;
            var result = db.Filmler.Where(f => f.FilmAD.Contains(strAra));
            dataGridView1.DataSource = result.ToList();
        }
    }
}
