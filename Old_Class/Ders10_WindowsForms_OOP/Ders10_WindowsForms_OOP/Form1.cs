using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders10_WindowsForms_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* araba arabaNesnesi = new araba();
             arabaNesnesi.ID = 1;
             arabaNesnesi.Marka = "Mazda";
             arabaNesnesi.Model = "6";
             arabaNesnesi.BilgiYaz();

             araba araba2 = new araba(2, "Mercedes", "S500");
             araba2.BilgiYaz();
            */
            Ogretmen ogretmen1 = new Ogretmen();
            ogretmen1.Ad = "SEKMEN";
            ogretmen1.Soyad = "Hoca";

            ogrenci ogrenci1 = new ogrenci(13212321,544,"arda","gazi",ogretmen1);
            ogrenci ogrenci2 = new ogrenci(78563, 1244, "seda", "yüzüak", ogretmen1);
            ogrenci ogrenci3= new ogrenci(477898787,128, "kerim", "şahin", ogretmen1);
            /*  ogrenciyazdir.Sinifogretmeni = "sekmen hoca";*/
            //ogrenciyazdir.BilgiYaz(ListBox listBox1);
           // ogrenciyazdir.Ogretmendegistir("Sekmen Hoca");
           // ogrenci1.BilgiYaz(listBox1);
            ogrenci1.Ogretmendegistir(ogretmen1);
           // ogrenci1.BilgiYaz(listBox1);
            ogrenci2.BilgiYaz(listBox1);
            ogrenci2.Ogretmendegistir(ogretmen1);
           // ogrenci2.BilgiYaz(listBox1);
             ogrenci3.BilgiYaz(listBox1);
            ogrenci3.Ogretmendegistir(ogretmen1);
            ogrenci3.BilgiYaz(listBox1);
            ogretmen1.ogrenciler.Add(ogrenci1);
            ogretmen1.ogrenciler.Add(ogrenci2);
            ogretmen1.ogrenciler.Add(ogrenci3);
            

        }
    }
}
