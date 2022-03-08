using System;
using System.Collections;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ////ArrayList liste = new ArrayList();
            //ArrayList liste = new ArrayList(50);

            //for (double i = 0; i < 5; i++)//
            //    liste.Add(12);

            ////Console.WriteLine(liste.Count);
            ////Console.WriteLine(liste.Capacity);
            
            //Console.WriteLine("Adet={0} Kapasite={1}",liste.Count,liste.Capacity);
            //Console.WriteLine($"Adet={liste.Count} Kapasite={liste.Capacity}");

            //liste[2]="11";

            //Stack

            Stack stack = new Stack();
            stack.Push(12);
            stack.Push(22);
            stack.Push(32);

            Console.WriteLine(stack.Peek());//en üsttekine bakar
            Console.WriteLine(stack.Pop()); // en üsttekini alır(siler).
            //stack.Pop(); //yazdırmadan göster
            Console.WriteLine(stack.Peek());
        }
    }
}
