using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList list1 = new ArrayList() {1,4,6,8,9};      // hata runtime da verilir.
                                                                // ( "on" ) array farklı tiplere
                                                                // izin verir ama foreach olduğundan çalışmaz.

            List<int> list2=new List<int>() { 1, 4, 6, 8, 9 };  // hata designtime da verilir.
                                                                //list farklı tiplere izin vermez.

            int toplam = 0;

            foreach (int sayi in list1)
            {
                toplam += sayi;
            }
            Console.WriteLine(toplam);

            toplam = 0;
            foreach (int sayi in list2)
            {
                toplam += sayi;
            }
            Console.WriteLine(toplam);
        }
    }
}
