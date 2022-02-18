using System;

namespace Yagıs
{
    class Yagis
    {
        public virtual void Yag()
        {
         Console.WriteLine("");
           
        }
    }
    class Kar:Yagis
    {
        public override void Yag()
        {
            Console.WriteLine("Kar yağacak.");
            for (int i=0;i<1500 ; i++)
            { Console.Write("*");
                Console.Write("   ");
                Console.WriteLine("\n");
            }
        }
    }
    class Yagmur : Yagis
    {
        public override void Yag()
        {
            Console.WriteLine("");
        }
    }
    class Dolu : Yagis
    {
        public override void Yag()
        {
            Console.WriteLine("");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Yagis Kar = new Kar();
            Kar.Yag();

        }
    }
}
