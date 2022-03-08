using Ders_11_OOP_Kalitim.Sahibinden;
using Ders11_OPP_Kalitim.Sahibinden;
using System;
using System.Threading;

namespace Ders_11_OOP_Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Kullanici Shakir = new Kullanici();
            Shakir.AdSoyad = "Şakir Demir";
            Shakir.Telefon = "05324445566";
            Console.WriteLine(Shakir.AdSoyad);

            //TEST
            int ilanno = 1;
            Ilan ilan = new Ilan();
            ilan.IlanNo = ilanno;
            ilan.Fiyat = 100;
            ilan.Baslik = "şok indirim";
            ilan.IlanTarihi = DateTime.Now;
            ilan.Satici = Shakir;
            ilan.BilgiYaz();
            ilanno++;

            Dizustu dzb = new Dizustu();
            dzb.Kategori = Kategori.Dizüstü_Bilgisayar;
            dzb.IlanNo = ilanno;
            dzb.IlanTarihi = DateTime.Now;
            dzb.Baslik = "Sağlam Dizüstü Bilgisayar";
            dzb.Agirlik = 2.3f;
            dzb.Islemci = "AMD Ryzen 7";
            dzb.Fiyat = 10000.0d;
            dzb.Marka = "HP";
            dzb.Model = "Pavilion";
            dzb.Bellek = "32GB";
            dzb.HDD = 0;
            dzb.SSD = 1024;
            dzb.EthernetVarMi = true;
            dzb.WifiVarMi = true;
            dzb.HdmiVarMi = true;
            dzb.EkranBoyutu = "14";
            dzb.Agirlik = 2.3f;
            dzb.Satici = Shakir;
            dzb.BilgiYaz();
            ilanno++;

            Masaustu msb = new Masaustu();
            msb.Kategori = Kategori.Dizüstü_Bilgisayar;
            msb.IlanNo = ilanno;
            msb.IlanTarihi = DateTime.Now;
            msb.Baslik = "Sağlam Huawei Masaüstü Bilgisayar";
            msb.Islemci = "AMD Ryzen 7";
            msb.Fiyat = 7000.0d;
            msb.Marka = "HUAWEI";
            msb.Model = "HW_7510";
            msb.Bellek = "16GB";
            msb.KasaTipi = KasaTipi.Dikey;
            msb.MonitorVarmi = true;
            msb.MonitorBaglanti = MonitorBaglanti.TypeC;
            msb.HDD = 500;
            msb.SSD = 0;
            msb.EthernetVarMi = true;
            msb.WifiVarMi = false;
            msb.HdmiVarMi = false;
            msb.Satici = Shakir;
            msb.BilgiYaz();
            ilanno++;


        }
    }
}