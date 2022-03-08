using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace Ders10_WindowsForms_OOP
{
    class Ogretmen
    {
       
        //ıd,ad,soyad,ogrenciler(list of ogrenci)
        //bilgiyaz(ad soyad)
        //ogrencilistele
        public int ID;
        public string Ad;
        public string Soyad;
        public List<ogrenci> ogrenciler;

        public Ogretmen()
        {//nesne oluşturulduğu anda RAM de liste için alan açılır.liste oluşturulur.
            this.ogrenciler = new List<ogrenci>();

        }
      private void OgrencileriListele()
        {
            MessageBox.Show("******" + Ad + " " + Soyad + "Öğretmenin öğrencileri");
            foreach (var item in this.ogrenciler)
            {
                MessageBox.Show(item.Ad + " " + item.Soyad);
            }
            MessageBox.Show("***************************");
        }



    }
}
