using System;
using System.Linq;

namespace ConsoleApp3
{
    class Personel
    {
        public Personel()
        {

        }
        public int PerID { get; set; }
        public string PerAdi { get; set; }
        public decimal Maas { get; set; }
public Personel(int id,string ad,decimal maas)
        {
            PerID = id;
            PerAdi = ad;
            Maas = maas;
        }

    }
    class Musteri
    {
        public int MusID { get; set; }
        public string MusAdi { get; set; }
        public decimal Cari{ get; set; }
    }
    class Arac
    {
        public string Plaka { get; set; }
        public Arac(string plaka)
        {
            Plaka = plaka;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //4-ctor (yapıcı inşa edeici)
            //5-destructure (yıkıcı method)
            //                                                      ?? Enumerable

            // kullanıcıyı veri girmeye zorlar.

            Personel p2 = new Personel();
            p2.PerID = 2;
            p2.PerAdi = "Cevdet";
            p2.Maas = 5600;

            Personel p3 = new Personel(12,"Selami",6700);

            // object inh.
            Musteri m = new Musteri { MusID=15,MusAdi="Deniz",Cari=7551};
            Musteri m2 = new Musteri();//boş zorlamaz

            Arac arac = new Arac("");
        }
    }
}
