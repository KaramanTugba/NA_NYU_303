using System;

namespace for_dongusu
{
    class Program
    {
        static void Main(string[] args)
        {/*
            int a;
            for(a=1;a<5;a++)//a5 kısımını silersen sonsuz döngüye girer //i+=10 10 ar 10 ar artar.
            { Console.WriteLine("hello world"+a.ToString()); }
            Console.WriteLine(a);
            int toplam = 0;
            for(int i=1;i<=10;i++)
            {
                 toplam +=i;
            }
            Console.WriteLine(" toplam:"+toplam);
*/
            /*
                        Console.Write("yazın :");
                        string m1 = Console.ReadLine();
                        for (int i = 1; ; i++)
                        {
                            if (m1.ToLower() == "çık")
                            {
                                Console.WriteLine("DÖNGÜ BİTTİ");
                                break;
                            }
                             else
                             {
                                 Console.Write("yazın :");
                                 m1 = Console.ReadLine();
                             }

                        }
            *///olmadı bu
            /* int top = 0;
             Console.WriteLine("girin");
             int s1 = Convert.ToInt32(Console.ReadLine());
             for(int i=1; i<s1; i++)
             {
                 top = i * 3;
                 i++;
                 Console.WriteLine(top);
             }
            *///try parse dene

            //Klavyeden girilen değer "bitir" olmadığı sürece alınan sayıları toplayıp en son ekrana toplamı yazdıran programı yazınız.
            /* int toplam = 0;
             int sayi = 0;
             string str = "";
             do
             {
                 Console.Write("Sayı giriniz : ");
                 str = Console.ReadLine();
                 int.TryParse(str, out sayi);
                 if (str.Length > 0 && sayi == 0 && str.ToLower() != "bitir" && str != "0")
                    Console.WriteLine($"Geçersiz sayı.");
                 toplam += sayi;
             }
             while (str!= "bitir");
             Console.WriteLine($"While loop ile TOPLAM = {toplam}");
            */
            /*
            int toplam = 0;
            int sayi = 0;
            string str = "";
            do
            {
                Console.Write("Sayı giriniz : ");
                str = Console.ReadLine();
                bool dogru =int.TryParse(str, out sayi);
                if (!dogru && str.ToLower() != "bitir" && str != "0")
                    Console.WriteLine($"Geçersiz sayı.");
                toplam += sayi;
            }
            while (str != "bitir");
            Console.WriteLine($"While loop ile bool kulandı TOPLAM = {toplam}");
            */
            /*
            int toplam = 0;
            int sayi = 0;
            string str = "";
            for(; ; )
            {
                Console.Write("Sayı giriniz : ");
                str = Console.ReadLine();
                
                if (str.ToLower() == "bitir")
                    break;
                bool dogru = int.TryParse(str, out sayi);
                if (!dogru && str.ToLower() != "bitir" && str != "0")
                    Console.WriteLine($"Geçersiz sayı.");
                toplam += sayi;
            }
        
            Console.WriteLine($"While loop ile bool kulandı TOPLAM = {toplam}");
        }
           *///çarpma tablosu
            /*int i, j;
            int top = 0;
            for(i=1; i<=10;i++)
            {
                for(j=1;j<=10;j++)
                {
                    top = i * j;
                    Console.WriteLine(i +"*"+j+"="+top);
                    //j++;//buray koyuylursa tekleri yazdırıyor
                    //i++; 10*10 3*3 şeklinde yazdırır.
                }
                //i++;//buraya koyulursa 1leri 3 leri 5 leri yazdırır
                // j++;açık olanla aynı şeyi yapıyor.
                Console.WriteLine(" ");
            }*/
            //1 ler 6 ları,2 lerle 7 leri.... diye alt alta yanyana 
            /*  int i, j;
              int top = 0;
              for (i = 1; i <= 10; i++)
              {
                  for (j = 1; j <= 10; j++)
                  {
                      top = i * j;
                      Console.Write(i + "*" + j + "=" + top+"\t");
                      Console.Write(i + "*" + j + "=" + top + "\t");
                      //j++;//buray koyuylursa tekleri yazdırıyor
                      //i++; 10*10 3*3 şeklinde yazdırır.
                  }
                  //i++;//buraya koyulursa 1leri 3 leri 5 leri yazdırır
                  // j++;açık olanla aynı şeyi yapıyor.
                  Console.WriteLine("");
              }
            */
            //fancy
            /*
            for (int i = 1; i <= 10; i++)
            {

                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i + "x" + j + "=" + (i * j)+ "\t");

                }
                Console.WriteLine("");
            }
            /*
            int i;
            for(i=1;i<=20;i++)
            {
                Console.WriteLine(i);
            }
            */
            //ikili grup halinde
            /*
            for (int i = 1; i <= 10; i++)
            {

                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(j + "x" + i + "=" + (i * j) + "\t");

                }
                Console.WriteLine("");
            }
            Console.WriteLine(" ");
            for (int i = 1; i <= 10; i++)
            {

                for (int j = 6; j <= 10; j++)
                {
                    Console.Write(j+ "x" + i + "=" + (i * j) + "\t");

                }
                Console.WriteLine("");
            }
            */
            /*
            int top = 0;
            int s1;
            int i;
            string str = Console.ReadLine();
            int.TryParse(str, out s1);
            for (i=2;i<=s1;i+=2)
            {
                Console.Write(i+" ");
                top += i;
                
            }
            Console.WriteLine("toplam=" + top);
            *///bilmiyorum bir bak
            /* int top = 0;
             int s1;
             int i;
             string str = Console.ReadLine();
             int.TryParse(str, out s1);
             for (i = 1; i <= s1; i++)
             {
                 if(i % 2 == 1)
 {
                     top += i;

                 }
             }
             Console.WriteLine("toplam=" + top);
            */
            /*
            int sayi, top = 0;
            string str = Console.ReadLine();
            int.TryParse(str, out sayi);
            for (int i = sayi; i >= 0; i--)
            {
                Console.Write(i + " ");
                top += i;

            }
            Console.WriteLine("top= "+top);
            */
            //iki sayi giriniz hangisi küçük ise o sayıdan bailayarak diğerine kadar olan sayıları yaz.
            /*
             int s1, s2;
             Console.Write("sayı 1: ");
             string str = Console.ReadLine();
             int.TryParse(str, out s1);

             Console.Write("sayı 2: ");
             str = Console.ReadLine();
             int.TryParse(str, out s2);

             int kucuk, buyuk;
             if(s1<s2)
             {
                 kucuk = s1;
                 buyuk = s2;
             }
             else
             {
                 kucuk = s2;
                 buyuk = s1;
             }
             for (int sayac = kucuk; sayac <=buyuk; sayac++)
             {
                 Console.Write(sayac+" ");
             }

            */
            //MARKETTE 5 ÜRÜNÜN FİYATI TEK TEK GİRİLİP HER BİRİ İÇİN %18 KDVLİ FİYATINI EKRANA YAZDIRAN.

            /*            double top = 0;
                        double tkdv = 0;
                        double i;
                        double sayi;
                        string str = "";
                        for (i=1;i<=5;i++ )
                        {
                            Console.Write("Sayı giriniz : ");
                            str = Console.ReadLine();


                            bool dogru = double.TryParse(str, out sayi);
                            if (!dogru)
                                Console.WriteLine($"Geçersiz sayı.");
                            top = sayi * (1.18);
                            Console.WriteLine($"kdvsi = {top}");
                            tkdv += top;
                        }
                        Console.WriteLine("toplam kdv li fiyat : "+tkdv);
               */
            /*
             int i;
             string met;
             string satirlar="";

             for (; ; )
             {
                 Console.WriteLine("Birşeyler yazınız: ");
                 string satir = Console.ReadLine();

                 if (satir.ToLower() == "çık")
                 {
                     Console.WriteLine("Girilen değerler : " + satirlar);
                     break;
                 }
                 else
                 {
                     satirlar += satir + "\n";
                 }
             }
             Console.WriteLine(satirlar);
         }
 */
            //1 10 arası sayıların faktöriyellerini yazdırıp , en altta hepsinin faktöriyel tolamını yazdıracak.
            /*
             int i,j;
             int aratoplam = 1;
             int toplam = 0;        

             for (i = 1; i <= 10; i++)
             {
                 aratoplam = 1;
                 for (j = i; j >= 1; j--)
                 {
                     aratoplam *= j;                                                    
                 }
                 Console.WriteLine(i + " faktöriyeli : "+aratoplam);
                 aratoplam += aratoplam;
             }
             Console.WriteLine("faktöriyeller toplamı : "+toplam);
            */
            /*
            int i, j, toplam = 0, aratoplam = 1;
            string bos = "                               ", formatli;
            for (i = 1; i <= 10; i++)
            {
                aratoplam = 1;
                for (j = 2; j <= i; j++)
                {
                    //Console.WriteLine(j);
                    aratoplam *= j;
                }
                toplam += aratoplam;
                formatli = aratoplam.ToString();
                formatli = bos.Substring(0, 5 - formatli.Length) + aratoplam.ToString();
                Console.WriteLine(i + " sayısının faktoriyeli= " + formatli);
            }
            Console.WriteLine("Faktoriyeller toplamı=   \t" + toplam);
        }

*/
            //yıldızdan dik üçgen yapmak
            string cizgi = "****************************************************************";
            for (int i = 1; i <= 30; i+=2)
            {
                Console.WriteLine(cizgi.Substring(0,i));
            }










        }
    }
    }


