using System;

namespace ConsoleApp1
{
    class Program
    {
        static int Faktoriyel(int sayi)
        {
            if (sayi == 1)
                return 1;
            Console.WriteLine(sayi);
            return Faktoriyel(sayi - 1) * sayi;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Faktoriyel(100));
            
        }
    }
}
