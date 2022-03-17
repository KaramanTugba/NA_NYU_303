using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10, b = 5, c = 0;
            //try
            //{
            //    c = a / b;
            //    Console.WriteLine("istisnadan sonra......");
            //}
            //finally
            //{
            //    Console.WriteLine("Ne olursa olsun çalış..........");
            //}

            int a = 10, b = 0, c = 0;
            try
            {
                c = a / b;
                Console.WriteLine("istisnadan sonra......");
            }
            catch(Exception ex)
            {
                Console.WriteLine("istisnai bir durum var");
            }
            finally
            {
                Console.WriteLine("Ne olursa olsun çalış..........");
            }
        }
    }
}
