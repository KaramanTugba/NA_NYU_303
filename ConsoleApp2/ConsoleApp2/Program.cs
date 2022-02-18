using System;

namespace ConsoleApp2
{
    class Program
    {
        static void MetodA(int sayi)
        { Console.WriteLine("MethodA içi (atamadan önce)"+sayi);
            sayi = 999;
            Console.WriteLine("MethodA içi (atamadan sonra)"+sayi);
        }
        public static void Yazdir(int[]sayilar)
        {
            foreach(int sayi in sayilar)
            {
                Console.Write(sayi+" ");
            }
            Console.WriteLine();
        }
        static void MethodB(int[] sayilar)
        {
            Console.WriteLine("MethodB içi (atamadan önce)" );
            Yazdir(sayilar);
            for(int i=0;i<sayilar.Length;i++)
            {
                sayilar[i] = -555;
            }
            Console.WriteLine("MethodB içi (atamadan sonra)" + sayilar);
            Yazdir(sayilar);
        }
        static void Main(string[] args)
        {
            //4-ctor (yapıcı inşa edeici)
            //5-destructure (yıkıcı method)
            int number = 1;
            MetodA(number);
            Console.WriteLine("method çağrıldıktan sonra"+number);
            int[] numbers = { 2, 2, 2, 2, 2, 2, 222, 2, 2 };
            MethodB(numbers);
            Console.WriteLine("methodb çağrıldıktan sonra");
            Yazdir(numbers);
            Console.ReadLine();
        }
    }
}
