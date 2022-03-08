using System;

namespace ConsoleApp3
{
    abstract class Sekil
    {
        public string Renk { get; set; }

    }
    class Daire:Sekil
    {

    }
    class Silindir :Daire
    {

    }
   sealed  class Koni : Silindir
    {

    }
    // Sealed olduğundan izin vermez.
    //class Kesikkoni:Koni
    //{

    //}
    static class Veritabani
    {
        public static void Kaydet()
        {

        }
    }
    class Baglan
    {
        public static void ConnectionString(string str) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract
            //Sekil sekil = new Sekil();

            Koni koni = new Koni();

            Veritabani.Kaydet();
            Baglan baglan = new Baglan();
            //baglan. Burada gözükmez static olduğu için
            Baglan.ConnectionString("");
            int[] sayilar = { 45, 654, 741, 85 };
            //sayilar.Sort yok.    Tek tek hepsine vermek yerine array a verip tek bir seferde işi hallediyor.
            Array
           
        }
    }
}
