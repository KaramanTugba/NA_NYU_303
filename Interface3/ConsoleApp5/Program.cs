using System;

namespace ConsoleApp5
{
    abstract class Sekil
    {
    }
    class Kare : Sekil
    {
    }
    class Kup : Kare,IHacim
    {
    }
    class Ferrari
    {

    }
    class Cizim<T> where T : Sekil
    {
    }

    interface IHacim
    {

    }

    class HacimHesapla<T> where T : IHacim { 

    }
    //sadece değere tipliler (struct). Boyutu belli olanlar.
    //class referans tipli yapılardır. Bunların boyutu belli değildir.

    // Generic yapılara kısıt koyularak sadece istenilen yerden 
    class Deneme<T> where T : struct
    {

    }
    //16 byte geçilirse referans tipli olur.

    //13 struct - 2 class
    //class: string , object
    class Emened<T> where T : class
    {

    }
    class Emlak<T> where T : class,new()
    {

    }
    class Ev
    {
        public Ev(string adres)  // varsayılan yapıcı: otomatik olusan boş yapıcı.
        {

        }
    }

    class Karavan
    {

    }
    struct Nokta
    {
        public int x;
        public int y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Generic Constraints

            //1-struct
            //2-class
            //3-Inheritance
            //4-Interface
            //5-new()

            Nokta nokta;
            nokta.x = 12;
            nokta.y = 12;

            Deneme<int> d1 = new Deneme<int>();
            Deneme<bool> d2 = new Deneme<bool>();
            // Deneme<string> d3 = new Deneme<string>(); //Engellendi.class

            //Emened<int> e1 = new Emened<int>();  //Engellendi.struct
            Emened<string> e2 = new Emened<string>();
            Emened<object> e3 = new Emened<object>();


            Cizim<Kare> c1 = new Cizim<Kare>();
            Cizim<Kup> c2 = new Cizim<Kup>();

            //Cizim<Ferrari> c3 = new Cizim<Ferrari>();  //Ferrari Sekilden turemediği için hata.
            //base class 

            //HacimHesapla<Kare> hh1 = new HacimHesapla<Kare>();
            //IHacim uygulanmadığından çalışmaz.
            HacimHesapla<Kup> hh2 = new HacimHesapla<Kup>();

            //new()
            //Tum kısıtlar içerisinde new mutlaka sonda olmak zorunda
            //Emlak<Ev> ev = new Emlak<Ev>(); //Default ctor yok.
            Emlak<Karavan> karavan = new Emlak<Karavan>();
        }
    }
}