using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Deneme<T>
    {
        public void IslemA(T t)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Zorunluluk durumu var.
            Deneme<string> deneme = new ConsoleApp3.Deneme<string>();

            ArrayList liste1 = new ArrayList();
            List<int> liste2 = new List<int>();

            DateTime basla, bitir;
            TimeSpan fark;

            // Atamaların her iki tarafınında type olarak aynı olması gerekmektedir.

            basla = DateTime.Now;
            for (int i = 0; i < 999999; i++)
            {
                liste1.Add(i);
                int sayi =(int)liste1[i];
            }
            bitir = DateTime.Now;
            fark = bitir - basla;
            Console.WriteLine($"İslem zamanı:(ArrayList){fark.TotalMilliseconds}");

            basla = DateTime.Now;
            for (int i = 0; i < 999999; i++)
            {
                liste2.Add(i);
                int sayi2 = (int)liste2[i];
            }
            bitir = DateTime.Now;
            fark = bitir - basla;
            Console.WriteLine($"İslem zamanı:(List){fark.TotalMilliseconds}");
        }
    }
}
