using System;
using System.Collections.Generic;
using System.Text;
using static Ders10_OPP_Examples.Enumlar;

namespace Ders10_OPP_Examples
{
    class Musteri
    {

        public int MusteriID;
        public string MusteriAdi;
        public string MusteriSoyadi;
        public DateTime DogumTarihi;
        public Cinsiyetler Cinsiyeti { get; set; }
        public UrunSepeti MusterininUrunSepeti { get; set; }
        public void MusteriBilgileriYazdır()
        { Console.WriteLine("müşteriıd:"+MusteriID+" "+"müşteri adı:"+MusteriAdi+" "+"müşteri soyadı: "+MusteriSoyadi); }
        public void MusterininSepetiniYazdir()
        {
            int sayac = 1;
            foreach(var item in MusterininUrunSepeti.UrunlerListesi)
            {
                Console.WriteLine(sayac+". ürününüz:"+item.UrunAdi);
                sayac++;
            }
        }
    
    
    
    
    }
}
