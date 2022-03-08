using System;
using System.Collections.Generic;
using System.Text;

namespace Ders10_OPP_Examples
{
    class UrunSepeti
    {
        public int SepetId { get; set; }
        public int MusteriId { get; set; }
        public List<Urun> UrunlerListesi= new List<Urun>();
    }
}
