using System;
using System.Collections.Generic;
using System.Text;
using static Ders10_OPP_Examples.Enumlar;

namespace Ders10_OPP_Examples
{
    class Urun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public UrunKategorileri UrunKategorisi { get; set; }
    }
}
