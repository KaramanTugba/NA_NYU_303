using System;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {/*
             //double prim = 6000;
            //double yilSayisi = 0;
            //while (prim < 7200)
            //{
            //    yilSayisi = (7200 - prim) / 360;
            //    Console.WriteLine("Emekliliğe daha " + Math.Round(yilSayisi, 2) +" yıl var, çalışmaya devam! ");
            //    Console.ReadLine();
            //    prim += 360;

            //}
            //Console.WriteLine("Tebrikler, emekli oldunuz :)");

            //While kullanarak 1'den 10'a kadar sayıları ekrana yazalım:
            //int limit = 1;
            //int sayi = -5;
            //Console.Write("Sayi:");
            //limit = Convert.ToInt32(Console.ReadLine());            
            //while (sayi <= limit)
            //{
            //    Console.WriteLine("Sayı=" + sayi);
            //    sayi++;
            //}

            //Klavyeden girilen değer ÇIK olmadığı sürece
            //alınan yazıları ekrana yazdıran prog.
            //While kullanarak.





            //Console.Write("Mesajınızı yazınız(Çıkmak için ÇIK yazınız):");
            //string yazi = ""; // Console.ReadLine();
            //while (yazi.ToLower() != "çık")
            //{
            //    Console.WriteLine(yazi);
            //    Console.Write("Mesajınızı yazınız(Çıkmak için ÇIK yazınız):");
            //    yazi= Console.ReadLine();
            //}
            //Console.WriteLine("Program sonlandı!");
            //Klavyeden girilen değer "bitir" olmadığı sürece alınan sayıları
            //Toplayıp, en son ekrana toplamı yazdıran prog. 
            //int toplam = 0;
            //int sayi;
            //try
            //{
            //    Console.Write("Sayı giriniz:");
            //    string str = Console.ReadLine();
            //    while (str.ToLower() != "bitir")
            //    {
            //        sayi = Convert.ToInt32(str);
            //        //if (int.TryParse(str, out sayi))
            //        {
            //            toplam += sayi;
            //        }
            //        Console.Write("Sayı giriniz:");
            //        str = Console.ReadLine();
            //    }
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("Dosya bulunamadı."  );
            //}

            //catch (SystemException e)
            //{
            //    Console.WriteLine("Sayı formatı hatalı, işlem yapılamadı!");
            //    Console.WriteLine("İşlemler geri alındı!");
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.Message);

            //}

            //finally
            //{
            //    if (toplam > 0)
            //        Console.WriteLine("Toplam=" + toplam);
            //}
            //Console.WriteLine("Program sona erdi");

            //Yıldız(*) ile 50 X 20 lik bir çerçeve olsun, içinde
            //üst tarafta Network Akademi yazsın.
            //Gerekirse while kullanılsın.
            //Console.WriteLine("**************************************************");
            //Console.WriteLine("* Network Akademi                                *");
            //int sayac = 1;
            //while (sayac <= 17)
            //{
            //    Console.WriteLine("*                                                *");
            //    sayac++;
            //}
            //Console.WriteLine("**************************************************");
            //Console.ReadLine();


            // en ve yukseklik klavyeden girilecek.
            // Zemin lacivert, yazılar sarı olsun.


            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //const int doluSatirSayisi = 3;
            //const int ikiYildiz = 2;

            //Console.Clear();

            ////int en = Convert.ToInt32( Console.ReadLine());
            //int en = 0, yukseklik = 0;
            //int minEn = 20;
            //int maxEn = 100;
            //int minYukseklik = 10;
            //int maxYukseklik = 30;
            //do
            //{
            //    Console.Write("En(20 ile 100 arası):");
            //    int.TryParse(Console.ReadLine(), out en);
            //} while (!(en >= minEn && en <= maxEn));
            //Console.Write("Yükseklik:");
            //do
            //{
            //    Console.Write("Yükseklik(10 ile 25 arası):");
            //    int.TryParse(Console.ReadLine(), out yukseklik);
            //} while (!(yukseklik >= minYukseklik && yukseklik <= maxYukseklik));
            // yukseklik = Convert.ToInt32(Console.ReadLine());

            // 

            //string uzun_cizgi = "*************************************************************************";
            //string network = "** Network Akademi                                                           ";
            //string bos_satir = "**                                                                          ";
            //try
            //{
            //    Console.WriteLine(uzun_cizgi.Substring(0, en));
            //Console.WriteLine(uzun_cizgi.Substring(0, en));
            //Console.WriteLine(network.Substring(0, en - 2) + "**");
            //int sayac = 1;

            //while (sayac <= yukseklik - doluSatirSayisi)
            //{
            //    Console.WriteLine(bos_satir.Substring(0, en - ikiYildiz) + "**");
            //    sayac++;
            //}
            //Console.WriteLine(uzun_cizgi.Substring(0, en));
            //Console.WriteLine(uzun_cizgi.Substring(0, en));
            //Console.ReadLine();
            //}
            //catch (SystemException e)
            //{
            //    Console.WriteLine("Bir hata oluştu, hata bilgisi:" + e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Program sona erdi.");
            //}




            int en = 0, yukseklik = 0;
            int minEn = 20;
            int maxEn = 100;
            int minYukseklik = 10;
            int maxYukseklik = 30;
            do
            {
                Console.Write("En(20 ile 100 arası):");
                int.TryParse(Console.ReadLine(), out en);
            } while (!(en >= minEn && en <= maxEn));
            
            do
            {
                Console.Write("Yükseklik(10 ile 30 arası):");
                int.TryParse(Console.ReadLine(), out yukseklik);
            } while (!(yukseklik >= minYukseklik && yukseklik <= maxYukseklik));
            Console.WriteLine("en: " + en + " yükseklik:" + yukseklik); 

            // Klavyeden girilen sayıları ekrana yazdıran prog.
            // koşullar: 5'in katlarında "BOM" yazsın, 19'un katı
            // girilince proramdan çıksın. 
            *//*
            Console.WriteLine("");
            int sayi = 0;
            while(true){
                do
                {
                    Console.WriteLine("sayı (10 -100 arası): ");
                    int.TryParse(Console.ReadLine(), out sayi);

                } while (!(sayi >= 10 && sayi <= 100));
                if(sayi%5==0)
                {
                    Console.WriteLine("BOM");
                }
                else if (sayi % 19 == 0)
                {
                    Console.WriteLine("19 un katı girildi, döngüden çıkııyor.");
                    break;
                }
                else
                {
                    Console.WriteLine(sayi.ToString());
                }
            
        }*/

            //1-10 arası sayılar yazılacak
            //7ye gelirse birşey yazmayacak
            //9 a gelince 9 u yazıp döngüden çıkacak.
            /*
            int i = 1;
            while(i<=15)
            {
                if(i==7)
                { i++;
                    continue;
                }
                if (i == 10)
                {
                    //Console.WriteLine("sadnbdsajkda"); 9 yaptığımda
                    break;
                }
                Console.WriteLine(i);
                i++;
            }
            */
            //1-girilen sayıya kadar arası tek çift olduğunu yazdıran

            int i = 1;
            Console.WriteLine("sayı gir: ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            while(i<=s1)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " çifttir.");
                    i++;
                }
                else if (i % 2 != 0)
                {
                    Console.WriteLine(i + " tektir.");
                    i++;
                }
                
                 
                    
            }
            

            }



        }
    }

