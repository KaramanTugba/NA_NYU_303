using System;

namespace ConsoleApp6
    //class ın diziymiş gibi kullanılması this-->Depo
{ class Depo
    {
        private string[] _depo = new string[10];
        public string this[int indis]
        {
            get { return _depo[indis]; }
            set { _depo[indis] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Depo depo = new Depo();
            //depo[0] = "";

            //string strMesaj = "Merhaba";
            //for(int i=0;i<strMesaj.Length;i++)
            //{
            //    Console.WriteLine(strMesaj[i]);
            //}

            
        }
    }
}
