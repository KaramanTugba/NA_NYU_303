using System;

namespace ConsoleApp1
{
    class Program
    {
        abstract class Sekil
        {
            public abstract void MethodA();
        }
        class Daire : Sekil
        {
            public override void MethodA()
            {
                throw new NotImplementedException();
            }
        }
        class Kare : Sekil
        {
            public override void MethodA()
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
