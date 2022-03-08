using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Yaz(int[] dizi)
        {
            foreach (int s in dizi)
                Console.WriteLine(s+" ");
            Console.WriteLine();
            
        }
        static void Yaz(string[] dizi)
        {
            foreach (string s in dizi)
                Console.WriteLine(s + " ");
            Console.WriteLine();

        }
        static void Yaz(double[] dizi)
        {
            foreach (double s in dizi)
                Console.WriteLine(s + " ");
            Console.WriteLine();

        }
        static void Yazdir<T>(T[] dizi)
        {
            foreach (T s in dizi)
                Console.WriteLine(s + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //Generic

            int[] sayilar = { 34, 45, 48, 87, 99, 3, 4 };
            string[] sehirler = { "İstanbul", "Ankara", "Bursa" };
            double[] fiyat = { 44.9, 88, 33.5, 78 };
            Yaz(sayilar);
            Yaz(sehirler);
            Yaz(fiyat);

            Yazdir<int>(sayilar);
            Yazdir<string>(sehirler);
            Yazdir(fiyat);


        }
    }
}
