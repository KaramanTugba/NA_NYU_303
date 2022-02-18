using System;

namespace ConsoleApp1
{
    class Personel
    { 
        private int id;
      //deger döndürecek
        public int getID()
        {//bir çok kez return yazılabilir.
            return id;
        }
        public void setID(int _id)
        {
            id = _id;
        }
        //özellik

        //class içinde default değer private dır.
        string _perAd;
        public string PerAd {
            get { return _perAd; } 
            set { _perAd = value; }
        }
        //c# 3.0 sonrası
        public decimal Maas { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {

            //class members
            //variable
            //method
            //property


      /*  for(int i=0;i<=5;i++)
            {
                Console.WriteLine(i);
            }
      */
            Personel personel= new Personel();
            //personel.id = 12;
            //int.TryParse
            

        }
    }
}
