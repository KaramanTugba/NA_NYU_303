using System;

namespace ConsoleApp5
{
    class Musteri
    {
        public int MusID { get; set; }
        public string MusAd { get; set; }
        public string Adres { get; set; }
        //ctor
        //public Musteri(string ad, string adres)
        //{
        //    MusAd = ad;
        //    Adres = adres;
        //}
        public Musteri(string ad, string adres) : this(1, ad, adres)
        {

        }
        public Musteri(int id, string ad, string adres)
        {
            MusID = id;
            MusAd = ad;
            Adres = adres;
        }
    }
    class Deneme{
        const double pi = 3.1415;
        readonly double katsayi = 1.5;
        public Deneme()
        {
            // pi = 2.5;
            katsayi = 1.1;
        }
        public void islem()
        {
            katsayi = 5.6;
        }
}

    class Program
    {
        static void Main(string[] args)
        {
            //6-readonly //sadece contractır içinde değişir.
            //7-const  //kesinlikle değişmez
        }
    }
}
