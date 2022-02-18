using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Topla(1,2,3,9));
          
            Console.WriteLine(ToplaString("a", "b", "c", "d"));
            Console.WriteLine("");
            //puan topla :(isim yaş puan)
            //string=isim+toplampuan
            int[] p = new int[3];
            p[0] = 75;
            p[1] = 85;
            p[2] = 90;
           // int toplam = p.Sum();//private static string Puantopla nın kısaltılmış hali.
            Console.WriteLine(Puantopla("ahmet", 44, p));
            // Console.WriteLine("toplam: "+toplam);
            //Recursive: Kendini çağıran metodlar.
            Console.WriteLine("7 in faktöriyeli: " + Faktoriyel(7));
            Console.WriteLine(" ");
            //referans tipi parametreler
            int s1;
            //int s1 = 5;
            int s2 = 7;
           // DegerDegistir(ref s1, s2); //ref methodun iindekini alır.//olmazsa 30.satırdaki şekliyle yazar.
           // Console.WriteLine("s1= " + s1);
           // Console.WriteLine("s2= " + s2);
            int s3 = DegerDegistir2(out s1);
            Console.WriteLine("s3= "+s3);
            Console.WriteLine("s1= "+s1);

        }//main sonu
         static int DegerDegistir2(out int sayi)
        {
            sayi = 77;
            return sayi+5;
        }
        private static void DegerDegistir(ref int s1, int s2)
        {
            s1 = s1 * 10;
            s2 = s2 * 100;
            Console.WriteLine("methodun içinde s1. " + s1);
            Console.WriteLine("methodun içinde s2: " + s2);
        }

        static int Faktoriyel(int sayi)
        {
            
            if (sayi <= 1)
            { return 1; }
            else
            {
               // Console.WriteLine("şuanda"+sayi+" * faktöriyel "+(sayi-1)+" çağrılıyor" );
                int carpim = sayi * Faktoriyel(sayi - 1);
                Console.WriteLine("çarpım :"+carpim);
                return carpim; 
            }
            
        }
        private static string Puantopla(string isim, int yas,  int[]puanlar)
        {
            int toplampuan = 0;
            foreach(int puan in puanlar)
            {
                toplampuan += puan;
            }
            return "İsim: "+isim + " Yaş: " + yas + " Toplam Puan: " + toplampuan;
        }

        static string ToplaString(params string[] sayilarstring)
        {
            string cumle = "";
            foreach (string kelime in sayilarstring)//sast sayilar string
            {
                cumle += kelime+" ";
            }
            return cumle;
        }
        static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            foreach(int sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }
    }
}
