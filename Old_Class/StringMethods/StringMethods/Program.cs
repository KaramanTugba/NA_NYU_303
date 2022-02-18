using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string birlesim = string.Concat("network ", "akademi ", "303sabah ", 2022);
            Console.WriteLine(birlesim);

            string[] dizi = { "Korkma ", "Sönmez ", "bu ", "şafaklarda " };
            birlesim = string.Concat(dizi);
            Console.WriteLine(birlesim);
            Console.WriteLine(" ");
            int[]intDizi= { 1,2,3,4,5,6 };
             birlesim = string.Concat(intDizi);
            Console.WriteLine(birlesim);
            Console.WriteLine(" ");
            string m1 = "adıyaman";
            string m2 = "adana";
            
            int comp = string.Compare(m1, m2);//1.2.den önce ise -1, diğer durumda +1 olur.
            Console.WriteLine("comp:"+comp);
            if(comp==-1)// -1 0 1 gelir
            {
                Console.WriteLine(m1);
            }
            else
                Console.WriteLine(m2);
            */
            /* for (int i = 0; i < 10; i++)
             {
                 Console.Write("string 1: ");
                 string st1 = Console.ReadLine();
                 Console.Write("string 2: ");
                 string st2 = Console.ReadLine();
                 int comp = string.Compare(st1.ToUpper(), st2.ToUpper());
                 if (comp == -1)
                     Console.WriteLine("önce gelen: " + st1.ToUpper());
                 else if (comp == 0)
                     Console.WriteLine("aynı sırada: " + st2);
                 else
                     Console.WriteLine("önce gelen: " + st2.ToUpper());
             }
            */
            /*
             Console.Write("string 1: ");
             string st3 = Console.ReadLine();
             Console.Write("string 2: ");
             string st4 = Console.ReadLine();
             int comp2 = string.Compare(st3, 0, st4, 0, 100, true); //0 olduğu halde kısa olanı yazar.
             if (comp2 == -1)
                 Console.WriteLine("önce gelen: " + st3);
             else if (comp2 == 0)
                 Console.WriteLine("aynı sırada: " + st4);
             else
                 Console.WriteLine("önce gelen: " + st4);
            */
            string metin = "BEŞİKTAŞ";
            Console.WriteLine(metin.IndexOf("Ş"));
            Console.WriteLine(metin.LastIndexOf("Ş"));
            Console.WriteLine(metin.StartsWith("BEŞ"));
            Console.WriteLine(metin.StartsWith("Beş"));
            Console.WriteLine(metin.EndsWith("TAŞ"));

            metin = "      ____________FENERBAHÇE___________       ";
            Console.WriteLine(metin.Trim('_',' ','B','A','H','Ç','E'));

            metin = "Merhaba Dünya";
            Console.WriteLine(metin.PadLeft(20,'.'));
            Console.WriteLine(metin.PadRight(20, '.'));

            string youtubeStr = "https://www.youtube.com/";
            string[] adres = youtubeStr.Split('/');
            Console.WriteLine(adres[2]); // / den sonralarını bölümler.
            Console.WriteLine("adres[0]=" + adres[0]);
            Console.WriteLine("adres[1]=" + adres[1]);
            Console.WriteLine("adres[2]=" + adres[2]);
            Console.WriteLine("adres[3]=" + adres[3]);
            Console.WriteLine("");
            string cumle = "Merhaba arkadaşlar bugün hava çok güzel.";
            string[] kelimeler = cumle.Split(' ');
            foreach(var kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
            Console.WriteLine("");
            string yeniCumle = string.Join(' ', kelimeler);  // join(" ") "/"
            Console.WriteLine(yeniCumle);

            yeniCumle = yeniCumle.ToUpper();
            Console.WriteLine(yeniCumle);
            yeniCumle = yeniCumle.ToLower();
            Console.WriteLine(yeniCumle);
            
            yeniCumle = yeniCumle.Remove(3, 1); //3. karakterden itibaren 1 karakteri siler
            Console.WriteLine(yeniCumle);

            Console.WriteLine(yeniCumle.Insert(6," 123 "));
            //Console.WriteLine(yeniCumle.Replace('a','e'));
            yeniCumle=yeniCumle.Replace('a', 'e');
            Console.WriteLine(yeniCumle.Replace("arkadaşlar", "gençler"));


            Console.WriteLine(yeniCumle.Substring(8));//cümlenin 8.karakterinden itibaren getirir.
            Console.WriteLine(yeniCumle[0]);
            //testyaz(string yazi) methodu.
            yeniCumle = "Network Akademi";
            TersYaz(yeniCumle);
            yeniCumle="Network Akademi";
            //kelime say(string yazi) methodu
            string yeniCumle2 = "ıts me monica  chandler";
            int k = kelimeSay(yeniCumle2.Replace("  "," "));//b
            Console.WriteLine(k);
        }//main sonu

        private static int kelimeSay(string yeniCumle2)
        {
            string[] dizi = yeniCumle2.Split(' ');
            return dizi.Length;
        }

        private static void TersYaz(string yenicumle)
        {
            for (int i = yenicumle.Length - 1; i >= 0; i--)
            {
                Console.Write(yenicumle[i]);
            }
            Console.WriteLine();
        }
    }
}
