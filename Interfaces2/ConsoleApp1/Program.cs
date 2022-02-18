using System;
using System.Collections.Generic;
using System.Collections;


namespace ConsoleApp1
{ 
    class Depo:IEnumerable
    {
        string[] _urunler = { "Urun1", "Urun2", "Urun3", "Urun4", "Urun5" };

        public IEnumerator GetEnumerator()
        {
            return _urunler.GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Depo depo = new Depo();
            foreach (var s in depo)
            {
                Console.WriteLine(s);
            }
        }
    }
}
