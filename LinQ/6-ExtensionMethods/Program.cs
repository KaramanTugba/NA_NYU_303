using System;
using System.Linq;

namespace _6_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //6-Extension Methods(Genişletme Metotları)

            int sayi = 12;
            Console.WriteLine(sayi.KareAl());

            string str = "deneme";
            Console.WriteLine(str.TersCevir());

            int no = 11;
            no.KareAl();
            //   -------------------
            //1-Static bir class olmalı
            //2-Mutlaka ststic sınıf içerisindeki metotlarda static olmalı
            //3-Metodun il parametresi this ile başlamalı,ilgili yapılara eklenmeli.

            string strMesaj = "Merhaba";
            Console.WriteLine(strMesaj.Eko(3));

            //7-Expression Tree
            //LinQ sorguları 2 şekilde yazılır.Asıl olan Expression Tree yontemi.
            //Sql cümlesi gibi yazmaya izin verir.Bazı sorgulara izin vermez.Temel kullanıma izin verir.

            int sayi5 = 2;
            Console.WriteLine(sayi5.KareAl().KupAl().IkiyeBol());

            //8-Lambda Expressions =>" 
            //delege vardır.
            int[] sayilar = { 3, 5, 6, 8, 1, 10 };
            foreach (var x in sayilar.Where(s=>s%2==1))
                Console.WriteLine(x);
        }
    }
}
