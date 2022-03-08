using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDK;

namespace KucukHarfeCevir
{
    public class KucukHarfeCevirEfekti : ISDK
    {
        public string EklentiAdi => "Küçük harfe Çevir Efekti";

        public string Islem(string str)
        {
            return str.ToLower();
        }
    }
}
