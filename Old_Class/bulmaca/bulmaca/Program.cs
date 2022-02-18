using System;
using System.Collections.Generic;

namespace bulmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FIND IT \"CAPİTALS\"");
            List<string> capitals = new List<string>() { "ANKARA", "CANBERRA", "VIENNA", "BAKU", "ROME", "TOKYO", "ATHENS", "BERLIN", "LONDON", "DILI", "BOGOTA", "SOFIA", "BRASILLA", "MINSK" };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("capital :");
                string s1 = Console.ReadLine();
                bool capitalscheck = capitals.Contains(s1.ToUpper());
                if (capitalscheck==true)
                {
                    Console.WriteLine($"{s1} is true.");
                }
                else
                    Console.WriteLine($"{s1} is not true.");
            }
           











        }
    } }
