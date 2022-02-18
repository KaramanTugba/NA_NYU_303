using System;
using System.Collections.Generic;
using System.Text;

namespace Ders11_OPP_Kalitim.Sahibinden
{
    class Dizustu:Bilgisayar
    {
        private string _EkranBoyutu;
        private float _Agirlik;
        public string EkranBoyutu { get => _EkranBoyutu; set => _EkranBoyutu = value; }
        public float Agirlik { get => _Agirlik; set => _Agirlik = value; }
        new public void BilgiYaz()
        {
            base.BilgiYaz();
            Console.WriteLine("Marka: "+base.Marka);
            Console.WriteLine("Model: "+base.Model);
            Console.WriteLine("İşlemci: "+base.Islemci);
            Console.WriteLine("Bellek: "+base.Bellek);
            Console.WriteLine("HDD: "+base.HDD);
            Console.WriteLine("SSD: " + base.SSD);
            string eth = "Yok";
            string wifi = "Yok";
            string hdmi = "Yok";
            if (base.EthernetVarMi)
                eth = "Var";
            if (base.WifiVarMi)
                wifi = "Var";
            if (base.HdmiVarMi)
                hdmi = "Var";
            Console.WriteLine("Ethernet: "+eth);
            Console.WriteLine("WIFI: " + wifi);
            Console.WriteLine("Ekran Boyutu: "+_EkranBoyutu);
            Console.WriteLine("Ağırlık: "+_Agirlik);
            Console.WriteLine("HDMI: "+hdmi);


        }

    }
}
