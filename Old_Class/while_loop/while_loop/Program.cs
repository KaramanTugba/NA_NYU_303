using System;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine();
           double prim = 3500;
            double sayac = 0;
            while(prim<7200)
            {

                sayac = (7200 - prim) / 360;
                Console.WriteLine("emekliliğe daha"+Math.Round(sayac,2)+" yıl var.");
                Console.ReadLine();
                prim += 360;

                
            }
            Console.WriteLine( "tebrikler.");

            */
            // 1 den 10 a kadar sayıları tekrar yazdır
            /*
           int i=1;
           int sayac = 0;
           while(sayac<10)
            { 
                
                Console.WriteLine(i);
                i++;
                sayac++;
            }
            */
            /*
            byte sayi = 1;
            while (sayi <= 10)
            {
                Console.WriteLine(sayi);
                sayi++;
            }
            */
            //girilen sayıdan, girilen diğer sayıya kadar yazdıracak.
            /*
             int sayi = Convert.ToInt32(Console.ReadLine());
             int bitis = Convert.ToInt32(Console.ReadLine());
             while (sayi <= bitis)
             {
                 Console.WriteLine(sayi);
                 sayi++;
             }
            */
            //çık yazmadığı sürece girileni yazdıran program
            /*
            Console.Write("mesaj giriniz (çıkmak için çık yaz):");
            string mesaj = Console.ReadLine();
            while(mesaj.ToLower()!="çıkış")
            {
                Console.WriteLine(mesaj);
                Console.Write("mesajı yazın (çıkmak için çık yaz): ");
                
                mesaj = Console.ReadLine();

                }

            Console.WriteLine("çıkıldı");
            */

            //girilen bitir değilse alınan sayıları toplayıp, son halini ekrana yazdıran prog.
            //buna iyi bak
            /*
            int toplam = 0;
            int sayi = 0;
            Console.Write("sayıgir: ");
            string msj = Console.ReadLine();
            while (msj.ToLower() != "bitir")
            {

                sayi = Convert.ToInt32(msj);
                toplam += sayi;

                Console.Write("sayıgir: ");
                msj = Console.ReadLine();

            }
            Console.WriteLine("toplamı " + toplam);
            */
            //aynısı ama bu sefer string olanları ayırıp sadece int leri topluyor.
            /*
            int tempInt = 0;
            int toplam = 0;
            int sayi = 0;
            Console.Write("sayıgir: ");
            string msj = Console.ReadLine();
            while (msj.ToLower() != "bitir")
            {
                if (int.TryParse(msj, out sayi))
                {
                   // sayi = Convert.ToInt32(msj);
                    toplam += sayi;
                }
                Console.Write("sayıgir: ");
                msj = Console.ReadLine();

            }
            Console.WriteLine("toplamı " + toplam);
            */
            /*
            int toplam = 0;
            int sayi;
            try
            {
                Console.Write("sayıgir: ");
                string msj = Console.ReadLine();
                while (msj.ToLower() != "bitir")
                {
                    // (int.TryParse(msj, out sayi))
                    
                         sayi = Convert.ToInt32(msj);
                        toplam += sayi;
                    
                    Console.Write("sayıgir: ");
                    msj = Console.ReadLine();

                }
            }
            catch(SystemException)
            { Console.WriteLine("sayı formatı hatalı işlem yok."); }
            finally
            {
                if(toplam>0)
                    Console.WriteLine("toplamı " + toplam);
            }
            */

            //* ile 50x20 lik çercece oluşturulacak.
            //network akademi yazılacak(içinde olacak)
            /*
            Console.WriteLine("**************************************************");
            Console.WriteLine("*                NETWORK AKADEMİ                 *");
            int sayac = 1;
            while(sayac<17)
            { Console.WriteLine("*                                                *");
                sayac++;
            }
            Console.WriteLine("**************************************************");
            Console.ReadLine();
            *///olmadı bu
            /*
            int i=0;
            Console.WriteLine("satır sayısı :");
            int sa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sütün sayısı : ");
            int su = Convert.ToInt32(Console.ReadLine());
            while(i<sa)
            { Console.Write("*");
                i++;
            }
            Console.Write("a");
            */
            /*
            string s = "123456789                                      *";
            Console.WriteLine(s.Substring(0, 5));//5 adet alır.
            Console.ReadLine();
            */
            //en ve yükseklik klavyeden dirilecek. zemin lacivert yazılar sarı olacak
            /*
             Console.BackgroundColor = ConsoleColor.DarkBlue;
             Console.ForegroundColor = ConsoleColor.Yellow;
             int i = 0;
             int a = 0;
             int b = 0;
            string c = " ";
             Console.WriteLine("satır sayısı :");
             int sa = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("sütün sayısı : ");
             int su = Convert.ToInt32(Console.ReadLine());

             while (i <=sa)
             {
                 Console.Write("*");
                 i++;
             }
            Console.Write("*");
            while (a<=su)
             {
                Console.Write(c);
                
                 a++;

             }
             while (b <= sa)
             {
                 Console.Write("*");
                 b++;
             }
            
            */









        }
    }
}
