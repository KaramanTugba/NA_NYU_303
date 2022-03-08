using System;

namespace ConsoleApp4
{// t anında ram de herhangi bir class oluştuğunu nasıl anlarsınız?
    class Asker
    {
        //int sayac = 0;
        static int sayac = 0;
        public Asker()
        {
            sayac++;
            Console.WriteLine(sayac);
        }
        ~Asker()
        {
            sayac--;
            Console.WriteLine(sayac);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Asker a1 = new Asker();
            Asker a2 = new Asker();
            Asker a3 = new Asker();

            
        }
    }
}
