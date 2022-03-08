using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Urun
    {
        public int UrunID { get; set; }
        public int KategoriID { get; set; }
        public string UrunAd { get; set; }
        public decimal Fiyat { get; set; }
        public override string ToString()
        {
            return UrunID + " " + UrunAd + " " + Fiyat;
        }
    }
}
