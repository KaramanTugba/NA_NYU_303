using System;
using System.Collections.Generic;

namespace methodlar_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //kısakenar ve uzunkenar kalvyeden alınacak.cevrealan methoduyla cevre ve alanı yazsın
            Console.Write("kısa kenar giriniz: ");
            int kk = Convert.ToInt32(Console.ReadLine());
            Console.Write("uzun kenar giriniz: ");
            int uk = Convert.ToInt32(Console.ReadLine());
            CevreAlan(kk, uk);
            ////1.metod kullanıcıdan veri girişi alan ve girilen stringi geri dönen yaz() methodu
            ///2.method cokyaz(int adet)adetkadar input(yaz) alacak list halinde geri döndürecek.
            
            //string ifade = yaz();
            //Console.WriteLine("yazdığınız ifade: "+ifade);
            List<string> gelensayilar = cokyaz(5);
            Console.WriteLine("yazdığınız şeyler ");
            foreach(var item in gelensayilar)
            {
                Console.Write(item+" ");
            }
            
        }

         static List<string> cokyaz(int v)
        {
            List<string> yazilar = new List<string>();
            for(int i=0;i<v;i++)
            {
                yazilar.Add(yaz());
            }
            return yazilar;  
        }

        static string yaz()
        {
            Console.WriteLine("yazı: ");
            string yaz = Console.ReadLine();
            return yaz;
           // return (Console.ReadLine()); //kısa şekilde.
        }
        static void CevreAlan(int kk,int uk)
        {
            int cevre = 2 * (uk + kk);
            int alan = kk * uk;
            Console.WriteLine("Alan  :"+alan);
            Console.WriteLine("Çevre :"+cevre);
        }
    }
}
