using System;

namespace _30._12._2021
{
    class Program
    {
        static void Main(string[] args)
        {

            /* // otoparkın ücret tarifesi şöyle: 0-3 saat: 4 tl 3-7:3tl 7-12:2 tl girilen saate göre para hesaplamak:
             int aa,dd;
             string a;
             Console.WriteLine("Kaç saat kalacak (0-12) : ");
             a = Console.ReadLine();
             aa = Convert.ToInt32(a);

             if(aa>0 && aa<3)
             {
                 dd = aa * 4;
                 Console.WriteLine("Tutar : "+dd);
             }
             else if (aa > 3 && aa < 7)
             {
                 dd = aa * 3;
                 Console.WriteLine("Tutar : "+dd);
             }
             else
             {
                 dd = aa * 2;
                 Console.WriteLine("Tutar : "+dd);
             }
            */

            // ---------------------------------- DÖNGÜLER --------------------------------


            /*  //1-3 arasındaki sayıları bulan program

              int toplam = 0;
              for (int i = 1; i <= 10000; i++)
                  toplam += i; // toplam=toplam+i
              Console.WriteLine("toplam : " + toplam);
           */
            //girilen sayının faktöriyelini hesaplayan program.
            /*
             double a,fak;
             string aa;
             Console.Write("girilen sayı : ");
             aa = Console.ReadLine();
             a = Convert.ToInt32(aa);
             for ( fak = 1; 1 <= a; a--)
                 fak =fak*a;
                 Console.WriteLine("faktöriyel : "+fak);

             */
            /* //başlangıç ve sonu verilen sayıların arasındaki sayıları yazdır
             string ss1, ss2;
             double s1, s2,i;
             Console.Write("1.sayı : ");
             ss1 = Console.ReadLine();
             s1 =Convert.ToDouble(ss1);

             Console.Write("2.sayı : ");
             ss2 = Console.ReadLine();
             s2 = Convert.ToDouble(ss2);

             for ( i = s1; i<=s2; i++)
                 Console.WriteLine(i);
            */
            /*  //for döngüsü kullanarak a dan z ye kadar olan harfleri yazdır.
              char i;
              Console.WriteLine("ALFABE : ");
              for(i = 'a'; i <= 'z'; i++)
                   Console.WriteLine(i);
            */
            /*  // i=97 z->122 sonra çevirme

               int i;
               Console.WriteLine("ALFABE : ");
               for (i = 97; i <= 122; i++)
                   Console.WriteLine(Convert.ToChar(i));
          */
            /*        //z den a ya yazıyor.
               char i;
             Console.WriteLine("Alfabe:");
             for (i = 'z';'a'<=i; i--)
                 Console.Write(i);
 */
            /*  int a;
              int i;
              Console.WriteLine("1-100 arası 3 ve 5 e bölünebilenler : ");
              for (i=1; i<101;i++)
                  if(a%3==0 && a%5==0)
                      Console.WriteLine(a);
               */
            /*  //klavyeden girilecek olan 10 sayıdan en büyük ve en küçüğünü yazdıran
              int buyuk = 0, kucuk = 0, sayi;
              for (int i = 1; i <= 10; i++)
              {
                  Console.Write("{0}. sayıyı giriniz. ", i);
                  sayi = Convert.ToInt32(Console.ReadLine());
                  if (i == 1)
                  {
                      buyuk = sayi;
                      kucuk = sayi;
                  }
                  if (kucuk > sayi)
                  {
                      kucuk = sayi;
                  }
                  if (buyuk < sayi)
                  {
                      buyuk = sayi;
                  }



              }
              Console.WriteLine("En büyük sayı{}", buyuk);
              Console.WriteLine("En küçük sayı{0}", kucuk);
              */

            /*int toplam = 0;

                        for(int i=1; i<=100; i++)
                        {
                            toplam +=i;
                        }
                        Console.WriteLine(toplam);    */

            /*   //girilen sayıları dahil ederek aralarındaki sayıların toplamını hesaplayan
               int toplam = 0;
               int s1, s2;
               string ss1, ss2;
               Console.WriteLine(" sayi gir. : ");
               ss1=Console.ReadLine();
               s1 = Convert.ToInt32(ss1);
               Console.WriteLine(" sayi gir. : ");
               ss2 = Console.ReadLine();
               s2 = Convert.ToInt32(ss2);
               if(s1>s2)
               {
                   for (int i = 1; i <=s1; i++)
                   {
                       toplam += i;

                   }
               }
               else if(s1<s2)
               {
                   for (int i = 1; i <=s2; i++)
                   {
                       toplam += s1;

                   }

               }
               else { Console.WriteLine("yanlış yaptın."); }

               Console.WriteLine(toplam);
   */
            /*
                        Console.WriteLine("1-100 arası tek sayılar");
                        for (int i = 0; i <= 100; i++)
                            if (i % 2 == 1)
                            { Console.WriteLine(i); }
                            else
                            {  }

*/

            //  ----------------------------------------------burdan sonrasını al---------------------------------- //
   /*        string ss;
            int s,top;
            for (int i = 1; i <= 6; i++)
                Console.WriteLine("sayı gir ");
                ss=Console.ReadLine();
                s= Convert.ToInt32(ss);
                if (s < 0)
                {
                top += i;
                
                }
                else
            { }
            Console.WriteLine(top);
            //---------------------------------------burası hocadan geldi-----------------------------------//

            Console.Write("1.Notu Girin:");
            int not1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Notu Girin:");
            int not2 = Convert.ToInt32(Console.ReadLine());
            double ort = (not1 + not2) / 2;
            if (ort >= 50)
                Console.WriteLine("Dersten Geçtiniz.");
            else
                Console.WriteLine("Dersten Kaldınız.");

            --------------------------------------------
            string kadi, sifre;
            Console.Write("Kullanıcı adını girin:");
            kadi = Console.ReadLine();
            Console.Write("Şifrenizi girin:");
            sifre = Console.ReadLine();
            if (kadi == "admin" && sifre == "1234")
                Console.WriteLine("Giriş işlemi başarılı.");
            else
                Console.WriteLine("Girdiğiniz kullanıcı adı veya şifre hatalı");

            ------------------------------------------------------
double odemeTutari;
            Console.Write("Ürünün fiyatını giriniz:");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            if (fiyat >= 100)
                odemeTutari = fiyat;
            else
                odemeTutari = fiyat + 5;
            Console.WriteLine("Ödemeniz gereken tutar {0} TL'dir.", odemeTutari);
            --------------------------------------------------------------------------
             string ad;
            Console.Write("isim bilgisi giriniz : ");
            ad = Console.ReadLine();
            int i = 0;
            while (i < 100)
            {
                Console.WriteLine("{0},{1}", (i + 1), ad);
                i++;
            }
            //---------------------------------------------------
            string ad;
            Console.Write("isim bilgisi giriniz :");
            ad = Console.ReadLine();
            int i = 0;
            do
            {
                Console.WriteLine("{0}.{1}", (i + 1), ad);
                i++;
            } while (i < 100);

            string mevsim;
            Console.Write("Bir mevsim adı giriniz : ");
            mevsim = Console.ReadLine();
            switch (mevsim)
            {
                case "ilkbahar": Console.Write("Mart Nisan Mayıs"); break;
                case "yaz": Console.Write("Haziran Temmuz Ağustos"); break;
                case "sonbahar": Console.Write("Eylül Ekim Kasım"); break;
                case "kış": Console.Write("Aralık Ocak Şubat"); break;
                default: Console.Write("Mevsim adı hatalı"); break;
            }
            Kullanıcı tarafından girilen iki sayıyı yapılan işlem seçimine göre uygun işlemlerin yapılmasını sağlayan c# console uygulaması (  4 işlem +,-,*,/    )
string s1, s2, secim;
            double sayi1, sayi2;
            Console.Write("1. sayıyı giriniz :");
            s1 = Console.ReadLine();
            Console.Write("2. sayıyı giriniz :");
            s2 = Console.ReadLine();
            sayi1 = Convert.ToDouble(s1);
            sayi2 = Convert.ToDouble(s2);
            Console.WriteLine("Toplama [+]");
            Console.WriteLine("Çıkarma [-]");
            Console.WriteLine("Çarpma  [*]");
            Console.WriteLine("Bölme   [/]");
            Console.Write("Seçiminiz : ");
            secim = Console.ReadLine();
            switch (secim)
            {
                case "+":
                    Console.WriteLine("Toplama işlemi seçildi");
                    Console.WriteLine(sayi1 + sayi2);
                    break;
                case "-":
                    Console.WriteLine("Çıkarma işlemi seçildi");
                    Console.WriteLine(sayi1 - sayi2);
                    break;
                case "*":
                    Console.WriteLine("Çarpma işlemi seçildi");
                    Console.WriteLine(sayi1 * sayi2);
                    break;
                case "/":
                    Console.WriteLine("Bölme işlemi seçildi");
                    Console.WriteLine(sayi1 / sayi2);
                    break;
                default: Console.Write("Geçersiz işlem"); break;
            }

            -----------------------------------------------------------

            int parksaati = 0;
            int ücret = 0;
            Console.Write("Park süresini giriniz: ");
            parksaati = Convert.ToInt32(Console.ReadLine());
            if (parksaati < 3)
                ücret = parksaati * 4;
            else if (parksaati > 3 && parksaati < 7)
                ücret = parksaati * 3;
            else if (parksaati >= 7 && parksaati < 12)
                ücret = parksaati * 2;
            else if (parksaati >= 12)
                ücret = parksaati * 1;
            Console.Write("ödenecek toplam park ücreti={0}", ücret);

            ---------------------------------------------------------
            Faktöriyel sorusu
            -------------------------------------------------- -

            int toplam = 0;
            for (int i = 1; i <= 3; i++)
                toplam += i; // toplam=toplam+i
            Console.Write("toplam={0}", toplam);

            -------------------------------------------------------
            float s;
            int si, f;
            bool a = true;
            for (; a;)
            {
                Console.Write("Lütfen Faktöriyelinin alınmasını istediğiniz sayıyı giriniz: ");
                s = Convert.ToSingle(Console.ReadLine());
                si = (int)s;
                if (si != s || s < 1)
                {

                    Console.WriteLine("Lütfen pozitif tam sayı giriniz:");
                    a = true;
                }
                else
                {
                    a = false;
                    for (f = 1; si > 1; si--)
                        f *= si; // f=f*si
                    Console.Write("Faktöriyeli {0}", f);

                }
                ----------------------------------------------------------------

                            Console.Write("Başlangıç :");
                int baslangic = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bitiş :");
                int bitis = Convert.ToInt32(Console.ReadLine());
                for (int i = baslangic; i <= bitis; i++)
                {
                    Console.WriteLine(i);
                }
                -------------------------------------------------------------------
                Console.WriteLine("a dan z ye alfabeyi yazdırınız:");
                char a = 'a';
                char z = 'z';
                char i = 'i';
                for (i = a; i <= z; i++)
                    Console.Write(i);
                Console.WriteLine("\nz den a ya alfabeyi yazdırınız:");
                for (i = z; i >= a; i--)
                    Console.Write(i);
                --------------------------------------------------------------------------
for (int i = 1; i <= 100; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    { Console.WriteLine(i); }
                }
                ---------------------------------------------------------------------------

                            int buyuk = 0, kucuk = 0, sayi;
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("{0}. sayıyı giriniz. ", i);
                    sayi = Convert.ToInt32(Console.ReadLine());
                    if (i == 1)
                    {
                        buyuk = sayi;
                        kucuk = sayi;
                    }
                    if (kucuk > sayi)
                    {
                        kucuk = sayi;
                    }
                    if (buyuk < sayi)
                    {
                        buyuk = sayi;
                    }



                }
                Console.WriteLine("En büyük sayı{0}", buyuk);
                Console.WriteLine("En küçük sayı{0}", kucuk);

                ------------------------------------------------------------------------------
                int toplam = 0;
                for (int i = 0; i <= 100; i++)
                {
                    toplam += i;
                }
                Console.WriteLine("Toplam = {0}", toplam);
                -----------------------------------------------------------------------------------
                int toplam = 0;
                Console.Write("Birinci sayiyi giriniz: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("İkinci sayiyi giriniz: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                if (sayi1 < sayi2)
                {
                    for (int i = sayi1; i <= sayi2; i++)
                    {
                        toplam += i;
                    }
                    Console.WriteLine(toplam);
                }
                else if (sayi2 < sayi1)
                {
                    for (int i = sayi2; i <= sayi1; i++)
                    {
                        toplam += i;
                    }
                    Console.WriteLine(toplam);
                }
                else
                {
                    Console.WriteLine("Sayilar birbirine eşittir: " + sayi1);
                }

                ---------------------------------------------------------------------------------
            for (int i = 1; i <= 100; i += 2)
                {
                    Console.WriteLine("{0}", i);
                }
                ------------------------------------------------------------------------------------------------
                          /*
                                      /* 1'den 1000'e(sınırlar dâhil) kadar olan sayılar içerisinde 5'e tam bölünen, ancak 7'ye 
                                          tam bölünemeyen sayıları alt alta listeleyen, bu sayıların kaç tane olduğunu ve toplamını yazan
                                          bir program yazınız.
                                      */
              /*              int toplam = 0, sayi = 0;
                for (int i = 5; i < 1001; i += 5)
                {
                    if (i % 35 == 0)
                        continue;
                    sayi++;
                    toplam += i;
                    Console.WriteLine(i);
                }
                Console.WriteLine("Sayısı: " + sayi);
                Console.WriteLine("Toplam: " + toplam);
                --------------------------------------------------------------------------------------
                 string ad;
                Console.Write("isim bilgisi giriniz : ");
                ad = Console.ReadLine();
                int i = 0;
                while (i < 100)
                {
                    Console.WriteLine("{0},{1}", (i + 1), ad);
                    i++;
                }
                //---------------------------------------------------
                string ad;
                Console.Write("isim bilgisi giriniz :");
                ad = Console.ReadLine();
                int i = 0;
                do
                {
                    Console.WriteLine("{0}.{1}", (i + 1), ad);
                    i++;
                } while (i < 100);
                --------------------------------------------------------------------------------------
              //while
              ------------
                Console.Write("yazdırmak istediğiniz metni giriniz: ");
                string ad = Console.ReadLine();
                Console.Write("Tekrar sayısını giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                int i = 0;
                while (i < sayi)
                {
                    Console.WriteLine("{0}.{1}", (i + 1), ad);
                    i++;
                }

                //do while
                ------------
                Console.Write("yazdırmak istediğiniz metni giriniz: ");
                string ad = Console.ReadLine();
                Console.Write("Tekrar sayısını giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                int i = 0;
                do
                {
                    Console.WriteLine("{0}.{1}", (i + 1), ad);
                    i++;
                } while (i < sayi);
                ---------------------------------------------------------

                FOR
    ------------------------------------------------------------------------------------------------------------------
double toplam = 0, sayi = 0;
                int i = 0, adet = 0;
                for (i = 0; i < 6; i++)
                {
                    Console.Write((i + 1) + ". sayıyı giriniz:");
                    sayi = Convert.ToDouble(Console.ReadLine());
                    if (sayi > 0)
                    {
                        toplam += sayi;
                        adet++;
                    }
                }
                double ortalama = toplam / adet;
                Console.WriteLine("Pozitif sayıların Ortalaması={0}", ortalama);

                WHİLE
                ------------------------------------------------------------------------------------------------------------------
double toplam = 0, sayi = 0;
                int i = 0, adet = 0;
                while (i < 6)
                {
                    Console.Write((i + 1) + ". sayıyı giriniz:");
                    sayi = Convert.ToDouble(Console.ReadLine());
                    if (sayi > 0)
                    {
                        toplam += sayi;
                        adet++;
                    }
                    i++;
                }
                double ortalama = toplam / adet;
                Console.WriteLine("Pozitif sayıların Ortalaması={0}", ortalama);

                DO - WHİLE
                ------------------------------------------------------------------------------------------------------------------
 double toplam = 0;
                int i = 0, adet = 0;

                do
                {
                    Console.Write((i + 1) + ". sayıyı giriniz:");
                    double x = Convert.ToDouble(Console.ReadLine());
                    if (x > 0)
                    {
                        toplam += x;
                        adet++;
                    }
                    i++;
                } while (i < 6);
                Console.WriteLine("Pozitif sayıların Ortalaması={0}", (toplam / adet));
            */
           
            }
        } }
