using System;

namespace _31._12._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //girilen sayıyının basamak 
            /*
            int sayi = Convert.ToInt32(Console.ReadLine());
            int basamak = 0;
            while(sayi>0)
            {
                basamak++;
                sayi = sayi / 10;
            }
            Console.WriteLine("girdiğiniz sayı "+ basamak.ToString()+" basamaklıdır.");
            */

            // RASGELE SAYİ ÜRETEN RANDOM
            /*  int[] array = new int[] { 1, 3, 5, 7, 9 };
              string[] gunler = { "PAZARTESİ", "SALI", "ÇARŞAMBA", "PERŞEMBE", "CUMA", "CUMARTESİ", "PAZAR" };
              Console.WriteLine(array[4]);
  */
            /* int[] intArray;
             intArray = new int[5];
             intArray[0] = 10;

             // dizinin ikinci dizinine değer ataa
             intArray[1] = 20;

             // sonraki dizinlerine değer ataa
             intArray[2] = 30;
             intArray[3] = 40;
             intArray[4] = 50;

             Console.Write("For Döngüsü :");
             for (int i = 0; i < intArray.Length; i++)
                 Console.Write(" " + intArray[i]);

             Console.WriteLine("");
            */
            /*
             * Console.Write("Foreach :");
             foreach (int i in inArray)
                 Console.WriteLine(" "+i)
            */
            /* int[] intArray;
             intArray = new int[5];
             intArray[0] = 10;

             // dizinin ikinci dizinine değer ataa
             intArray[1] = 20;

             // sonraki dizinlerine değer ataa
             intArray[2] = 30;
             intArray[3] = 40;
             intArray[4] = 50;
             int j = 0;
             while (j < intArray.Length)
             {
                 Console.Write(" " + intArray[j]);
                 j++;
             }
            *///tanımlanan sayılar dizisindekileri toplayan
            /*
             int[] sayilar = { 10, 20, 15, 5, 7, 3, 4, 12, 8, 39, 2 };
             int top = 0;
             foreach (int sayi in sayilar )
             {
                 top=top+sayi ;
             }
             //int top = array[0] + array[1] + array[2] + array[3] + array[4] + array[5] + array[6] + array[7] + array[8] + array[9];
             Console.WriteLine(top);
            */
            // dizi içerisindeki en büyük en küçük bulma

            /*            int[] dizi = { 10, 20, 15, 5, 7, 3, 4, 12, 8, 39, 2 };
                        int enbuyuk = dizi[0];
                        int enkucuk = dizi[0];
                        for (int i = 0; i < dizi.Length; i++)
                        {
                            if (dizi[i] > enbuyuk)
                                enbuyuk = dizi[i];

                            if (dizi[i] < enkucuk)
                                enkucuk = dizi[i];
                        }
                        Console.WriteLine("En küçük :{0}", enkucuk);
                        Console.WriteLine("En büyük :{0}", enbuyuk);

            */

            //dizide olan notlardan 50 üstü geçer,altı kalır not alacak kaç öğrenci geçti kaldı.

            /* int[] dizi = { 40,60,50,70,30,34,60,20,80,100 };
             int g=0;
             int k=0;
             int ge, ka;
             for (int i = 0; i < dizi.Length; i++)
             {
                 if (dizi[i] >= 50)
                      g++;

                 else if (dizi[i] < 50)
                      k++;
                 else
                     Console.WriteLine("yanlış");
             }
             Console.WriteLine("GEÇEN SAYISI :"+ g);
             Console.WriteLine("KALN SAYISI :"+ k);
            */
            /*
                        //girilen gün adının haftanın kaçıncı günü olduğunu bulan
                        string hafta;
                        string[] gunler = { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" };
                        Console.WriteLine("gün giriniz: ");
                        hafta = Console.ReadLine();
                        for (int i = 0; i < gunler.Length; i++)
                        {

                            if (hafta == gunler[i])
                            {
                                Console.WriteLine(i + 1 + ". gündür");
                            }
            }
            */

            /* //sgirilen sınıf mevcudu,kişi yazdırılacak.en sonda liste yapılacak.
             string mmev,ka;
             int mev;

             Console.WriteLine("sınıf listesi");
             mmev = Console.ReadLine();
             mev = Convert.ToInt32(mmev);
             string[] ogrenci = new string[mev];
             for (int i=0;i<mev;i++)
             {
                 Console.WriteLine("kişi adı : ");
                 ogrenci[i] = Console.ReadLine();

             }
             foreach (string sayi in ogrenci)
             {
                 Console.WriteLine(sayi);
             }

             */
            /* //do while ile
             int k = 0;
             do
             {
                 Console.Write(" " + intArray[k]);
                 k++;
             } while (k < intArray.Length);

             Console.ReadLine();
             */

            /*  // 20 elemanlı dizide rasgele -100 100 arası sayılar atayan,negatif ,pozitif ,işaretsiz sayısını veren.
              int pozitif = 0;
              int negatif = 0;
              int notr = 0;
              Random rnd = new Random();
              int[] sayilar = new int[20];
              for (int i = 0; i < 20; i++)
              {
                  sayilar[i] = rnd.Next(-100, 100);
              }
              foreach (int sayi in sayilar)
              {
                  Console.WriteLine(sayi);
                  if (sayi > 0)
                  {
                      pozitif++;
                  }
                  else if (sayi < 0)
                  {
                      negatif++;
                  }
                  else
                  {
                      notr++;
                  }
              }
              Console.WriteLine("Pozitif sayı adeti >>> " + pozitif);
              Console.WriteLine("Negatif sayı adeti >>> " + negatif);
              Console.WriteLine("Nötr sayı adeti >>> " + notr);
            */
            //int dizi içindekitek sayıları foreach döngüsüyle ekrana yazdıran ve tek sayıların adedini ekranda gösteren programı yazınız.
            /*    int[] dizi = { 10, 15, 20, 33, 22, 11, 9, 8, 48, 47, 12, 35, 15, 21 };
                int t = 0;
                int c = 0;


                foreach (int sayi in dizi)
                {
                  //  Console.WriteLine(sayi);
                    if (sayi % 2 == 0)
                    {
                        c++;
                    }
                    else if (sayi % 2 == 1)
                    {
                        t++;
                    }
                    else
                    {
                        Console.WriteLine("yanlış");
                    }
                }
                    Console.WriteLine("çift sayı sayı adeti >>> " + c);
                    Console.WriteLine("tek sayı adeti >>> " + t);
            */
            /*  //girilen 10 sayıda kaç tane pozitif kaç tane negatif var
              int  poz = 0;
              int nega = 0;
              int sifir = 0;
              int[] sayilar = new int[10];
              for (int i = 0; i <10; i++)
              {
                  Console.Write("Sayı Giriniz : ");
                  sayilar[i] = Convert.ToInt32(Console.ReadLine());

              }

              foreach (int sayi in sayilar)
                  {

                      if (sayi > 0)
                      {
                          poz++;
                      }
                      else if (sayi < 0)
                      {
                          nega++;
                      }
                      else
                      {
                          sifir++;
                      }
                 }
                  Console.WriteLine("Pozitif sayılar " + poz+" adettir.");
                  Console.WriteLine("Negatif sayılar " + nega+" adettir.");
                  Console.WriteLine("İşaretsiz sayı " + sifir + " adettir.");

         *///girilen metine göre sessiz sesli harfleri sayan
            /*   string cumle;
               int seslisayac = 0;
               int sessizsayac = 0;
               Console.Write("Metni Giriniz:");
               cumle = Console.ReadLine();
               char[] sesliler = { 'ü', 'ö', 'ı', 'a', 'e', 'i', 'o', 'u' };
               for (int x = 0; x < cumle.Length; x++) //metin
               {
                   for (int i = 0; i < sesliler.Length; i++) //sesliler lenght =8
                   {
                       if (cumle[x] == sesliler[i])
                       {
                           seslisayac++;
                       }

                   }
               }
               sessizsayac = cumle.Length - seslisayac;
               Console.WriteLine("sesli harfler:" + seslisayac.ToString());
               Console.WriteLine("sessiz harfler:" + sessizsayac.ToString());
            */

            /* //klavyeden girilen sayıya kadar olan asal sayıları ekrana yazdıran.
             int dikkat = 0;
             Console.Write("Sayı Girin : ");
             int sayi = Convert.ToInt32(Console.ReadLine());

             for (int i = 2; i < sayi; i++)  //yazdığın sayıya kadar kontrol edilecek. 10 yazdın, 10 a kadar 2 den başlayarak kontrol edecek.böylece bilimum bölünecek sayıları bulur ve bunları kendine böler.
             {
                 if (sayi % i == 0)
                     dikkat++;
             }

             if (dikkat != 0)
                 Console.WriteLine("ASAL DEĞİL");
             else
                 Console.WriteLine("ASAL");
            */
            //girilen sayının kendinden önceki 2 sayının toplamını yazdıran program
            int sayi;
            int top = 0;
            Console.WriteLine("sayı gir: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            top = (sayi - 1) + (sayi - 2);
            Console.WriteLine("\nişte " + top);











        }
    }
}
