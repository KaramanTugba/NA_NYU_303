using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Market<Urun> market = new Market<Urun>();

            market.UrunEkle(new Bulgur { UrunID = 23, UrunAdi = "Pilavlık Bulgur", Fiyat = 10, TET = DateTime.Parse("25/02/2022") });
            market.UrunEkle(new CamBardak { UrunID = 44, UrunAdi = "6 lı Su Bardağı", Fiyat = 35, Kirik = true });
            market.UrunEkle(new CamBardak { UrunID = 45, UrunAdi = "8 lı Su Bardağı", Fiyat = 45, Kirik = false });
            market.UrunEkle(new KagitHavlu { UrunID = 87, UrunAdi = "24lü kağıt havlu", Fiyat = 85 });
            market.UrunEkle(new Sut { UrunID = 84, UrunAdi = "1lt Sut", Fiyat = 10, Tipi = "Keçi", SKT = DateTime.Parse("18/02/2022") });
            market.UrunEkle(new Yumurta { UrunID = 30, UrunAdi = "15li Yumurta", Fiyat = 25, Kirik = true, SKT = DateTime.Parse("19/02/2022") });
            market.UrunEkle(new Yumurta { UrunID = 33, UrunAdi = "30li Yumurta", Fiyat = 45, Kirik = false, SKT = DateTime.Parse("28/02/2022") });

            //Urun Listele
            Console.WriteLine("TUM URUNLER");
            foreach (var item in market.TumUrunler())
            {
                Console.WriteLine(item);
            }
            //Kirik urunleri Lİstele
            Console.WriteLine("KIRIK URUNLER");
            foreach (var item in market.KirikUrunler())
            {
                Console.WriteLine(item);
            }
            //BozUK ÜRÜN
            Console.WriteLine("BOZUK URUNLER");
            foreach (var item in market.BozukUrunler())
            {
                Console.WriteLine(item);
            }
        }   
    }
}
