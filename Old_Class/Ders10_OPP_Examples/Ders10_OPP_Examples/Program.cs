using System;
using static Ders10_OPP_Examples.Enumlar;

namespace Ders10_OPP_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Urun u1 = new Urun()
                {
                    UrunAdi = "Ekmek",
                    UrunId = 1000,
                    UrunKategorisi = UrunKategorileri.Gıda

                };
                Urun u2 = new Urun()
                {
                    UrunAdi = "Şarj Aleti",
                    UrunId = 1001,
                    UrunKategorisi = UrunKategorileri.Elektronik

                };
                Urun u3 = new Urun()
                {
                    UrunAdi = "Şampuan",
                    UrunId = 1002,
                    UrunKategorisi = UrunKategorileri.Temizlik

                };
                Urun u4 = new Urun()
                {
                    UrunAdi = "Süt",
                    UrunId = 1003,
                    UrunKategorisi = UrunKategorileri.Gıda

                };
                Musteri m = new Musteri()
                {
                    MusteriID = 1,
                    Cinsiyeti = Cinsiyetler.Erkek,
                    DogumTarihi = new DateTime(1969, 1, 1),
                    MusteriAdi = "Veysel",
                    MusteriSoyadi = "Peru"
                };
                UrunSepeti musterininsepeti = new UrunSepeti()

                {
                    MusteriId = m.MusteriID,
                    SepetId = 1
                };
                musterininsepeti.UrunlerListesi.Add(u1);
                musterininsepeti.UrunlerListesi.Add(u2);
                musterininsepeti.UrunlerListesi.Add(u3);
                musterininsepeti.UrunlerListesi.Add(u4);
                //Önce sepeti ve sepete eklenecek ürünleri yukarıda aldık, sonra bu sepeti müşteriye atadık.
                m.MusterininUrunSepeti = musterininsepeti;
                m.MusteriBilgileriYazdır();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

    }
}
