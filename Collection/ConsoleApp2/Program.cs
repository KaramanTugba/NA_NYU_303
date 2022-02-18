using System;
using System.Collections;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(12);
            q.Enqueue(22);
            q.Enqueue(32);

            Console.WriteLine(q.Peek()); //en üsttekine gösterir.
            Console.WriteLine(q.Dequeue()); // en üsttekini alır(siler).
            Console.WriteLine(q.Peek());

            //Hashtable

            Hashtable ht = new Hashtable();
            ht.Add(34,"İstanbul");
            ht.Add(16, "Bursa");
            ht.Add(6, "Ankara");

            Console.WriteLine(ht[34]);

            //SortedList

            SortedList sl = new SortedList(); //key kısmındakine göre sıralama yapılır.
            sl.Add(34,"Istanbul");
            sl.Add(6, "Ankara");

            Console.WriteLine(sl.GetByIndex(0));
          
        }
    }
}
