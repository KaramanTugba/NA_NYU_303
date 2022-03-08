using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matematik;
using Kimya;

namespace DllMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Cebir cebir = new Cebir();
            Console.WriteLine(cebir.KareAl(4));
            Console.WriteLine(cebir.KupAl(5));

            OrganikKimya organikKimya = new OrganikKimya();
            organikKimya.KovalentBaglar();
            organikKimya.IyonikBaglar();
        }
    }
}
