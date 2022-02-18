using System;
using System.Collections.Generic;
using System.Text;


namespace Ders11_OPP_Kalitim.Sahibinden
{
    enum KasaTipi
    {
        Dikey,
        Yatay,
        ThinClient
    }
    enum MonitorBaglanti
    {
        TypeA,
        TypeB,
        TypeC
            }
    class Masaustu:Bilgisayar
    {
        private bool _MonitorVarmi;
        private KasaTipi _KasaTipi;
        private MonitorBaglanti _MonitorBaglanti;
        public bool MonitorVarmi { get => _MonitorVarmi; set => _MonitorVarmi = value; }
        public KasaTipi KasaTipi { get => _KasaTipi; set => _KasaTipi = value; }
        public MonitorBaglanti MonitorBaglanti { get => _MonitorBaglanti; set => _MonitorBaglanti = value; }
        new public void BilgiYaz()
        {
            base.BilgiYaz();
            Console.WriteLine("Marka: " + base.Marka);
            Console.WriteLine("Model: " + base.Model);
            Console.WriteLine("İşlemci: " + base.Islemci);
            Console.WriteLine("Bellek: " + base.Bellek);
            Console.WriteLine("HDD: " + base.HDD);
            Console.WriteLine("SSD: " + base.SSD);           
            string monitor = "Yok";
            if (MonitorVarmi)
                monitor = "Var";
            Console.WriteLine("Monitor: "+monitor);
            Console.WriteLine("Monitor Bağlantı Tipi: " + MonitorBaglanti);
            Console.WriteLine("KasaTipi: " + KasaTipi);
            string eth = "Yok";
            string wifi = "Yok";
            string hdmi = "Yok";
            if (base.EthernetVarMi)
                eth = "Var";
            if (base.WifiVarMi)
                wifi = "Var";
            if (base.HdmiVarMi)
                hdmi = "Var";
            Console.WriteLine("Ethernet: " + eth);
            Console.WriteLine("WIFI: " + wifi);
            Console.WriteLine("HDMI: "+hdmi);




        }
    }
}
