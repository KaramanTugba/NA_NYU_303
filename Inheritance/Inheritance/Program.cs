using System;

namespace Inheritance
{
    class Asker
    {
        public int SicilNo { get; set; }
        public string Vazife { get; set; }
        protected void Islem()              //kendisi ve türeyen class ta erişilebilir.
        {

        }
    }
    class Insan 
    {
    
    }
    class Er:Asker//,Insan olamaz.
    {
        public Er()
        {
             
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Asker asker = new Asker();
            Er er = new Er();
            
        }
    }
}
