using System;

namespace ConsoleApp2
{
    class Personel
    {
        public Personel()
        {
            Console.WriteLine("personel sınıfı çalıştı.");
        }
    }
    class Mudur : Personel
    {
        public Mudur()
        {
            Console.WriteLine("müdür sınıfı oluştu.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Personel p = new Personel();
            Mudur mudur = new Mudur();
        }
    }
}
