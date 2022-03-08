using Ders_11_OOP_Kalitim.Sahibinden;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders11_OPP_Kalitim.Sahibinden
{
    class Bilgisayar:Ilan
    {
        private string _Marka;
        private string _Model;
        private string _Islemci;
        private string _Bellek;
        private short _HDD;
        private short _SSD;
        private bool _EthernetVarMi;
        private bool _WifiVarMi;
        private bool _HdmiVarMi;

        public string Marka { get => _Marka; set => _Marka = value; }
        public string Model { get => _Model; set => _Model = value; }
        public string Islemci { get => _Islemci; set => _Islemci = value; }
        public string Bellek { get => _Bellek; set => _Bellek = value; }
        public short HDD { get => _HDD; set => _HDD = value; }
        public short SSD { get => _SSD; set => _SSD = value; }
        public bool EthernetVarMi { get => _EthernetVarMi; set => _EthernetVarMi = value; }
        public bool WifiVarMi { get => _WifiVarMi; set => _WifiVarMi = value; }
        public bool HdmiVarMi { get => _HdmiVarMi; set => _HdmiVarMi = value; }


    }
}
