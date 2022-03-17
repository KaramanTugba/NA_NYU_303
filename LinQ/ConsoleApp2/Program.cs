using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Yaz<T>(List<T> liste)
        {
            foreach (T t in liste)
            {
                Console.WriteLine(t);
            }
        }
        static void Main(string[] args)
        {
            //LinQ Sorguları
            //1-Sql gibi
            //var sonuc = from u in UrunData.Urunler
            //            select u;


            //Yaz(sonuc.ToList());

            //int ID = 112;
            //var sonuc = from u in UrunData.Urunler
            //            where u.UrunID == ID
            //            select u;
            //ID = 113;
            //Yaz(sonuc.ToList());
            //113 YAZAR

            //int ID = 112;
            //var sonuc = (from u in UrunData.Urunler
            //            where u.UrunID == ID
            //            select u).ToList();
            //ID = 113;
            //Yaz(sonuc.ToList());
            //Yaz(sonuc);
            ////112 YAZAR
            ///
            //var sonuc = UrunData.Urunler.Where(u => u.UrunID == 111).ToList();
            //Yaz(sonuc);

            //var sonuc = UrunData.Kategoriler.Select(u => u).ToList();
            //Yaz(sonuc);

            //var sonuc = from u in UrunData.Urunler
            //            select new { ID = u.UrunID, Ad = u.UrunAd };
            //Yaz(sonuc.ToList());

            //var sonuc = UrunData.Urunler.Select(u => new { u.UrunID, u.UrunAd });
            //Yaz(sonuc.ToList());

            //var sonuc = from u in UrunData.Urunler
            //            join k in UrunData.Kategoriler
            //            on u.KategoriID equals k.KategoriID
            //            select new { u.UrunID, u.UrunAd, k.KategoriAd };

            var sonuc = UrunData.Urunler.Join(UrunData.Kategoriler, 
                u => u.KategoriID, k => k.KategoriID, (u, k) => new { u.UrunID, u.UrunAd, k.KategoriAd });
          
            Yaz(sonuc.ToList());
        }
    }
}
