using System;

namespace Interface3
{
    class Program
    {
        interface IAarayuz
        {
            void IslemA();
            void IslemB();
            void IslemC();
            void IslemD();
        }
        class A : IAarayuz
        {
            public void IslemA()
            {
                throw new NotImplementedException();
            }

            public void IslemB()
            {
                throw new NotImplementedException();
            }

            public void IslemC()
            {
                throw new NotImplementedException();
            }

            public void IslemD()
            {
                throw new NotImplementedException();
            }
        }
        interface IArayuzII
        {
            void IslemA();
        }
        interface IArayuzIII : IArayuzII
        {
            void IslemB();
        }
        class Deneme : IArayuzIII
        {
            public void IslemA()
            {
                throw new NotImplementedException();
            }

            public void IslemB()
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
            //Solid Yazılım
           

        }
    }
}
