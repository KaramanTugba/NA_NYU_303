using System;

namespace ConsoleApp4
{
    class Personel
    {
        public Personel()
        {//ctor +tab+tab
            Console.WriteLine("Nesne Oluştu.");
        }
        //diconstracter
        ~Personel()
        {
            Console.WriteLine("Nesne Silindi.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Personel p = new Personel();
            //Console.ReadLine();
        }
    }
}
