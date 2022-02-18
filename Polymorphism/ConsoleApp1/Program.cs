using System;

namespace ConsoleApp1
{
    class Personel
    {
        public int PerID { get; set; }
        public string PerAdi { get; set; }
        public override string ToString()
        {
            return PerID + " " + PerAdi;
        }
    }
    class Musteri
    {
        public int MusID { get; set; }
        public string MusAdi { get; set; }
        public override string ToString()
        {
            return MusID + " " + MusAdi;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        
        //Personel p = new Personel();
        //Musteri m = new Musteri();
        int sayi = 12;
        //namespace+class
        //Console.WriteLine(p);
        //Console.WriteLine(m);
        Console.WriteLine(sayi);

            Object obj = new Object();
            Console.WriteLine(obj);
        Personel p = new Personel() { PerID = 11, PerAdi = "Cevdet" };
        Musteri m = new Musteri() { MusID = 12, MusAdi = "Ali" };
            Console.WriteLine(p);
            Console.WriteLine(m);
        }
    }
}
