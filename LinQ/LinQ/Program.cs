using System;
using System.Collections.Generic;

namespace LinQ
{class Personel {
        //AUTO-PROP.
        public int PerID { get; set; }
        public string PerAD { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //LinQ
            //1-var
            var sayi = 12;
            var ad = "Cevdet";
            var kontrol = true;
            var pers = new Personel();
            var fiyat = 9.99m;
            var karakter = 'A';

            //sayi = "naber";
            //var
            dynamic deger = 12;
            deger = "Hi";

            object degisken1 = 12;
            int sayi1 = (int)degisken1;

            dynamic degisken2 = 12;
            int sayi2 = degisken2;

            //2-Auto-property
            //3-Object Init.
            Personel p = new Personel { PerID = 123, PerAD = "Cevdet" };
            //4-Collection Init.
            List<Personel> personeller = new List<Personel>
            {
                new Personel{PerID=111,PerAD="selami"},
                new Personel{PerID=112,PerAD="ali"}
            };

            //5-Anonim Nesne(TİP)
            var nesne = new { ID = 124, AD = "CEVDET", MAAS = 5544 };

        }
    }
}
