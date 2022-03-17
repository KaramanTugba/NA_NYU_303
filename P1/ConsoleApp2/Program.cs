using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        delegate void Temsilci();
        static bool TekSayiMi(int s)
        {
            return s % 2 == 1;
        }
        static void Yaz(List<int>sayilar)
        {
            Console.WriteLine();
            foreach (int s in sayilar)
            {
                Console.Write(s+" ");
            }
        }
        static void Islem(int s) { }
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int> { 2, 4, 6, 7, 9, 1, 50, 3 }; //koleksiyon olduğundan count yazılır

            //Klasik yöntem
            for (int i = 0; i < sayilar.Count; i++)
                if (sayilar[i]%2==1)
                    Console.Write(sayilar[i]+" ");

            //1.yöntem
            Predicate<int> p = new Predicate<int>(TekSayiMi);
            Yaz(sayilar.FindAll(p));

            //2.yöntem
            Yaz(sayilar.FindAll(TekSayiMi));

            //Yaz(sayilar.FindAll(Islem)); //Hata verir.Return type

            //Anonim Metodlar
            Temsilci t = delegate ()
              {
                 // Console.WriteLine("Anonim Method");
              };
            t();

            //3.yöntem
            Yaz(sayilar.FindAll(delegate(int s)
            { return s % 2 == 1; }));

            //4.yöntem
            Yaz(sayilar.FindAll(s => s % 2 == 1));
        }
    }
}
