using System;

namespace _5._01._22
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int say = 0;
         sayalim:
             Console.WriteLine("sıradaki sayı : " + say);  // bu şekilde taki int patlayana kadar komutu çalıştırır.
             say++;
             goto sayalim;
             Console.WriteLine("buraya geldik");
            */
            /*
            int say = 0;
        sayalim:
            Console.WriteLine("sıradaki sayı : " + say);  
            say++;
            if (say <=100)
            { goto sayalim; }
            Console.WriteLine("buraya geldik");
            */

            //faktöriyel (goto)
            /*
            int fak = 1;
            int n= Convert.ToInt32(Console.ReadLine());
        faktoriyel:
            fak *= n;
            n--;
            if (1 < n)
                goto faktoriyel;
            Console.WriteLine(fak);
            */

            //formül math.pow kullanmadan :

            //klavyeden taban ve üst bilgisi alın, hesaplayın.
            /*
                        int sonuc = 1;
                        Console.Write("taban yaz : ");
                        int taban = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("üst yaz : ");
                        int us = Convert.ToInt32(Console.ReadLine());
                    uslusayı:
                        sonuc *= taban;
                        us--;
                        if (us >= 1)  //us>0
                            goto uslusayı;
                        Console.WriteLine(sonuc);

            */
            //klavyeden girilen sayı 0-100 arasında değil ise tekrar isteyen program. 3 sayı alınacak.ar. oratalaması yazılacak.
            /* //BU BENİM YAPTIĞIM
            int ort=0;

        aritmetik:
           
            Console.WriteLine("Sayı1 giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı2 giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı3 giriniz : ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0 && sayi < 100 && sayi2 > 0 && sayi2 < 100 && sayi3 > 0 && sayi3 < 100)
            {
                ort = (sayi + sayi2 + sayi3) / 3;
                Console.WriteLine("arit.ortalama : " + ort);
            }
            else
                goto aritmetik;
*/
            /*
             //BU HOCANIN YAPTIĞI
             double toplam= 0;
             int sayac = 1;
         sayiiste:
             Console.WriteLine(sayac + " . Sayıyı Giriniz : ");
             int s = Convert.ToInt32(Console.ReadLine());
             if (s >= 0 && s < 100)
             {
                 toplam += s;
                 sayac++;
             }
             else
                 goto sayiiste;
             if (sayac <= 3)
                 goto sayiiste;
             Console.WriteLine("3sayının ortalaması :"+Math.Round((toplam/3),2));

 */
            //switch case
            /*
            string seviye ;
            switch(seviye)
            {
                case "kolay":
                    Console.WriteLine("seviye = kolay");
            }
            */
            // 2 sayı gir.işlem bilgisi alıp hesapla çıkış yazarsa sonlandır.
            islemtekrar:
            Console.WriteLine("1.sayı :");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1.sayı :");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("toplama çıkarma çarpma bölme çıkış :");
            string islem = Console.ReadLine();
            switch (islem)
            {
                case "toplama":
                    Console.WriteLine("toplam : "+(a1+a2));
                    break;
                case "çıkarma":
                    Console.WriteLine("çıkarma : " + (a1 - a2));
                    break;
                case "çarpma":
                    Console.WriteLine("çarpma : " + (a1 * a2));
                    break;
                case "bölme":
                    if(a2==0)
                        Console.WriteLine("0 ile bölünemez.");
                    else
                        Console.WriteLine("bölüm : " + (a1 / a2));
                    break;
                case "çıkış":
                    goto cikis;
                    break;
                default:
                    Console.WriteLine("yanlış");
                    goto cikis;
                    break;
            }
            if (islem != "çıkış")
                goto islemtekrar;
            cikis:
            Console.WriteLine("işlem sona erdi.");
            











        }
        }
    } 
