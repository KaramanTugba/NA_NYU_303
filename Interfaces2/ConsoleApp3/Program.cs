using System;

namespace ConsoleApp3
{
    public enum Gunler:byte{ Pazartesi, Sali=10, Carsamba=15, Persembe, Cuma, Cumartesi, Pazar }
   class Hafta
    {
        public Gunler Gun { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ENUM 
            //enum sadece int alınır.varsayılan değeri
            // 

           // Console.ForegroundColor = ConsoleColor.Yellow;
           // Console.WriteLine("Merhaba");
           for(int i=0;i<16;i++)
            {
                Console.ForegroundColor = (ConsoleColor)i;
                Console.WriteLine("Merhaba");
            }
            //ConsoleKey
            Console.WriteLine((int)Gunler.Pazar);
            Hafta hafta = new Hafta();
            hafta.Gun = Gunler.Pazartesi; //belirlenen seçeneklerden birini seçmeye zorlar.
            hafta.Gun = (Gunler)1;
        }
    }
}
