using System;

namespace _29._12._2021
{
    class Program
    {
        static void Main(string[] args)
        {

            //  type türü
            /*                                                                           
                        Type a = typeof(int);
                       Console.WriteLine();
           */

            // if - else 

            /*
                        int a = 7, b = 5;
                        if(a<b)
                        {
                            Console.WriteLine("a b'den küçük  ");
                            Console.Write(a);
                        }
                        else
                        {
                            Console.WriteLine("a b'den büyük  ");
                            Console.Write(b);
                        }
            */

            /*         Console.Write("Cinsiyet giriniz (k,e): ");
                     char cins = Convert.ToChar(Console.ReadLine());
                     if (cins == 'k')
                     {
                         Console.WriteLine("kadınsınız");
                     }
                     else if(cins=='e')
                     {
                         Console.WriteLine("erkek");
                     }
                     else
                     {
                         Console.WriteLine("Başka ifade girdiniz.");
                     }
         */
            //girilen 2 notun ortalaması 50 ve 50'den büyükse geçti, düşükse kaldı yazdıran program.
            /*
            double s1, s2, ort;
            string ss1, ss2;
            Console.Write("NOT BİLGİSİ 1 : ");
            ss1=Console.ReadLine();
            s1 = Convert.ToDouble(ss1);

            Console.Write("NOT BİLGİSİ 2 : ");
            ss2 = Console.ReadLine();
            s2 = Convert.ToDouble(ss2);

            ort = (s1 + s2) / 2;
            if(ort>=50)
            {
                Console.WriteLine("\nGEÇTİNİZ");
            }
            else
            {
                Console.WriteLine("\nKALDINIZ.");
            }
            */
            /*
            string kka, ppa;
            string ka = "tugba";
            string pa = "sifre";
            Console.Write("KULLANICI ADI GİRİNİZ : ");
           kka= Console.ReadLine();
            Console.Write("PAROLA GİRİNİZ : ");
            ppa = Console.ReadLine();
            if(kka==ka && ppa==pa)
            {
                Console.WriteLine("\nHOŞGELDİNİZ");
            }

            else
            {
                Console.WriteLine("\nYANLIŞ GİRİŞ.TEKRAR DENEYİN");
            }
            *//*
            double fi,son;
            string ffi;
            Console.Write("ÜRÜN FİYATI GİRİNİZ : ");
            ffi = Console.ReadLine();
            fi = Convert.ToDouble(ffi);
            if(fi>=100)
                {
                Console.WriteLine("TOPLAM : " + fi);
            }
            else
            {
                son = fi + 5;
                Console.WriteLine("TOPLAM : " + son);
            }
*//*
            double s;
            string ssayi;
            Console.Write("sayıgiriniz : ");
            ssayi=Console.ReadLine();
            s = Convert.ToDouble(ssayi);
            if (s >0)
            {
                Console.WriteLine("pozitif");
            }
            else if(s==0){
                Console.WriteLine("sıfır");
            }
            else
            {
                Console.WriteLine("negatif");
            }

*//*
            //girilen 2 sayıdan ve yazılan işlem türüne göre işlem yapacak.
            double s1, s2,sonuc;
            string ss1, ss2,ac;
            char a;
            Console.Write("sayi 1 girin : ");
            ss1 = Console.ReadLine();
            s1 = Convert.ToDouble(ss1);
            Console.Write("sayi 2 girin : ");
            ss2 = Console.ReadLine();
            s2 = Convert.ToDouble(ss2);
            Console.Write("işlem seçin (+,-,*,/) : ");
            ac = Console.ReadLine();
            a = Convert.ToChar(ac);
            if (a == '+')
            {
                sonuc = s1 + s2;
                Console.WriteLine("SONUÇ " + sonuc);
            }
            else if (a == '-')
                    {
                        sonuc = s1 - s2;
                        Console.WriteLine("SONUÇ " + sonuc);
                    }
                    else if (a == '*')
                        {
                            sonuc = s1 * s2;
                            Console.WriteLine("SONUÇ " + sonuc);
                        }
                        else if (a =='/')
                            {
                if (s2 != 0)
                {
                    sonuc = s1 / s2;
                    Console.WriteLine("SONUÇ " + sonuc);
                }
                else { Console.WriteLine("Payda 0 olamaz."); }
                            }
                            else { Console.WriteLine("YANLIŞ YAPTIN."); }
        
            */
            /*  //klavyeden girilen 2 ürün fiyatı 200 den büyükse, en düşük fiyatlı ürüne %25 indirim yapılacak.
              string ff1, ff2;
              double s1, s2, top,sale,ind;
              Console.Write("1.ürün fiyat : ");
              ff1 = Console.ReadLine();
              s1 = Convert.ToDouble(ff1);
              Console.Write("2.ürün fiyat : ");
              ff2 = Console.ReadLine();
              s2 = Convert.ToDouble(ff2);
              top = s1 + s2;
              if (top > 200)
              {
                  if (s1 > s2)
                  {
                      ind = s2-(s2 * 0.25);
                      sale = s1 + ind;
                      Console.WriteLine("İNDİRİMLİ TUTAR : " + sale);
                  }
                  else
                  {
                      ind = s1-(s1 * 0.25);
                      sale = s2 + ind;
                      Console.WriteLine("İNDİRİMLİ TUTAR : " + sale);
                  }

              }
              else
              {
                  Console.WriteLine("TUTAR : " + top);
              }

  */
            // bilgisyarın tarih bilgisini alarak hgangi günde olduığumuzu bulan program
            /*         
                      int gun = (int)DateTime.Now.DayOfWeek;
                      Console.Write("bugün günlerden : ");
                      switch(gun)
                      {
                          case 1:
                              Console.Write("pazartesi");
                              break;
                          case 2:
                              Console.Write("salı");
                              break;
                          case 3:
                              Console.Write("çarşamba");
                              break;
                          case 4:
                              Console.Write("perşembe");
                              break;
                          case 5:
                              Console.Write("cuma");
                              break;
                          case 6:
                              Console.Write("cumartesi");
                              break;
                          case 7:
                              Console.Write("pazar");
                              break;
             */

            /*   //kullanıcya kaçıncı ayda olduğunu sorarak hangi mevsimde olduğunu yazan program
               int gun=(int)DateTime.
               int ay;
               string aay;
               Console.WriteLine("hangi aydasın : ");
               aay = Console.ReadLine();
               ay = Convert.ToInt32(aay);
               switch (ay)
               {
                   case 12:
                   case 1:
                   case 2:
                       Console.WriteLine("kış mevsimi");
                       break;
                   case 3:
                   case 4:
                   case 5:
                       Console.WriteLine("ilkbahar mevsimi");
                       break;

                   case 6:
                   case 7:
                   case 8:
                       Console.WriteLine("yaz mevsimi");
                       break;

                   case 9:
                   case 10:
                   case 11:
                       Console.WriteLine("sonbahar mevsimi");
                       break;

                   default:
                       Console.WriteLine("ay bilgisi yanlış.");
                       break;

               }
            */
            /*
            // klavyeden giriş yapılan mevsim adına göre o mevsimde yer alan ayları ekrana yazdıran
            string mmev;
            Console.WriteLine("mevsim gir : ");
            mmev = Console.ReadLine();
            switch(mmev)
            {
                case "kış":
                    Console.WriteLine("aralık ocak şubat");
                    break;
                case "ilkbahar":
                    Console.WriteLine("mart nisan mayıs");
                    break;
                case "yaz":
                    Console.WriteLine("haziran temmuz ağustos ");
                    break;
                case "sonbahar":
                    Console.WriteLine("eylül ekim kasım");
                    break;
                default:
                    Console.WriteLine("öyle bir mevsim yok.");
                    break;
               
                     }
            *//*
            string renk;
            Console.Write("Trafik ışığı rengi : ");
            renk = Console.ReadLine();
                switch (renk)
            {
                case "kırmızı":
                    Console.WriteLine("\nDUR");
                    break;
                case "yeşil":
                    Console.WriteLine("\nGEÇ");
                    break;
                case "sarı":
                    Console.WriteLine("\nDİKKAT");
                    break;
                default:
                    Console.WriteLine("\n"+$"{renk} bir trafik ışığı rengi değil.");
                    break;

            }
            *//*
           
            string ss1, ss2,islem;
            double s1, s2,top;
            Console.WriteLine("BİRİNCİ SAYI : ");
            ss1=Console.ReadLine();
            s1 = Convert.ToDouble(ss1);
            Console.WriteLine("İKİNCİ SAYI : ");
            ss2 = Console.ReadLine();
            s2 = Convert.ToDouble(ss2);
            Console.Write("İşlem (+,-,*,/) : ");
            islem= Console.ReadLine();
            switch (islem)
            {
                case "+":
                    top = s1 + s2;
                    Console.WriteLine(top);
                    break;
                case "-":
                    top = s1 - s2;
                    Console.WriteLine(top);
                    break;
                case "*":
                    top = s1 * s2;
                    Console.WriteLine(top);
                    break;
                case "/":
                    if(s2==0)
                    { Console.WriteLine("PAYDA 0 OLAMAZ."); }
                    else
                    {
                        top = s1 / s2;
                        Console.WriteLine(top);
                    }
                    break;
                default:
                    Console.WriteLine("+ - * / KULLANIN.");
                    break;
                

            }
        }*/
            string a;
            char b;
            Console.WriteLine("HARFİ GİRİNİZ");
            a = Console.ReadLine();
            if (a.Length >= 2)
            { Console.WriteLine("1 den fazla girilemez."); }
            else
            {
                switch (a)
                {
                    case "a":
                    case "e":
                    case "ı":
                    case "i":
                    case "o":
                    case "ö":
                    case "u":
                    case "ü":
                        Console.WriteLine("ünlü");
                        break;
                    default:
                        
                        Console.WriteLine("ünsüz");
                        break;
                }
            }










        }
        }
    } 

