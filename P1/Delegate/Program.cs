using System;

namespace Delegate_1
{
    class Program
    {
        public delegate void Temsilci();
        static public void Mesaj()
        {
            Console.WriteLine("MESAJ");
        }
        static public void Gunaydin()
        {
            Console.WriteLine("Günaydın");
        }
        static public void Merhaba(string str)
        {
            Console.WriteLine("Merhaba");
        }
       static public string Hi()
        {
            return "Hi";
        }
       static void Main(string[] args)
        {
            //Delegate:Temsilci

            Temsilci t = new Temsilci(Mesaj);
            t += Mesaj;
            t += Gunaydin;
            //t += Hi; //return type yanlış
            //t += Merhaba; //imzası farklı
            //t -= Mesaj;

            //t(); //çalıştırmak için

            //multicase delegate: 1 delegenin içinde birden fazla method varsa

            foreach (Delegate  del in t.GetInvocationList())
            {
                //Console.WriteLine(del.Method.Name);
                if (del.Method.Name != "Mesaj")
                    del.DynamicInvoke();
            } 

        }
    }
}
