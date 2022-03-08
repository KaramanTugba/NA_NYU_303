using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDK;

namespace BuyukHarfeCevir
{
    public class BuyukHarfeCevirEfekti : ISDK
    {
        public string EklentiAdi => "Büyük harfe çevir efekti";

        public string Islem(string str)
        {
            return str.ToUpper();
        }
    }
}
