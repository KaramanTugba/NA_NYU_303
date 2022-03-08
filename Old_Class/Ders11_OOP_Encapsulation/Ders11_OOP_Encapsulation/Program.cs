using System;
using System.Threading;

namespace Ders11_OOP_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Kullanici ahmet = new Kullanici();
            ahmet.AdSoyad = "Ahmet ÇELİK";
            ahmet.Telefon = 5415062020;
            Bisiklet bisan = new Bisiklet();
            bisan.Marka = "Bisan";
            bisan.VitesSayisi = 27;

            Kiralama kiralama = new Kiralama();
            kiralama.Kullanici = ahmet;
            kiralama.Bisiklet = bisan;
            kiralama.Baslat();
           // Thread.Sleep(10000);
            kiralama.Bitir();



        }
    }
}
