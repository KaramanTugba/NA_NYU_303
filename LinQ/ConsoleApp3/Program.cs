using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception Handling (İstisnaların yakalanması)
            //Uygulama çalışırken, rutinin dışında durdurulmasına(sonlandırılmasına) denir.
            //int a = 10, b = 2, c = 0;
            //c = a / b;
            //Console.WriteLine("Bölmeden sonraki işlemler");
            //Console.WriteLine(c); //2 yazar

            int a = 10, b = 0, c = 0;
            int[] sayilar = { 3, 6, 7, 1 };
            try
            {
                int s=sayilar[10];
                c = a / b;
            }
            catch (DivideByZeroException ex) { Console.WriteLine("Dosyaya yaz...Sıfıra Bölünme"); }
            catch(IndexOutOfRangeException ex) { Console.WriteLine("Sms Gönder...Index out of Range"); }
            catch (Exception ex){ Console.WriteLine(ex.Message); }
            //catch { Console.WriteLine("Istisnai durum oluştu."); }
            Console.WriteLine("Bölmeden sonraki işlemler");
            Console.WriteLine(c); //hata verir.
        }
    }
}
