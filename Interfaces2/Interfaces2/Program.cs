using System;
using System.Collections;

namespace Interfaces2
{ /*interface Deneme{}*/ //
    interface IArayuz
    {
        void IslemA();
        
    }
    class Deneme:IArayuz
    {
        public void IslemA()
        {
            throw new NotImplementedException();
        }

        public void MethodA()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Interfaces2

            Deneme deneme = new Deneme();
            IArayuz deneme2 = new Deneme();
            deneme2.IslemA();//sadece islem çıkar
            ArrayList liste = new ArrayList();
            //liste.AddRange();
            //Array
            






        }
    }
}
