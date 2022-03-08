using System;
using System.Collections.Generic;
using System.Text;

namespace Ders11_OOP_Encapsulation
{
    class Kiralama
    {
        public int ID { get; set; }
        public Bisiklet Bisiklet { get; set; }
        public Kullanici Kullanici { get; set; }
        public float Sure { get; set; }
        public float Ucret { get; set; }
        public DateTime BaslamaZamani { get; set; }
        public DateTime BitisZamani { get; set; }
        public float SaniyeUcreti { get; set; }
        public Kiralama()
            {
            SaniyeUcreti = 0.25f;
            }
        public void Baslat()
        {
            BaslamaZamani = Convert.ToDateTime("2022.02.02 13:30:00.000");
        }
        public void Bitir()
        {
            BitisZamani = DateTime.Now;
            UcretHesaplama();
        }
        public void UcretHesaplama()
        {
            TimeSpan ZamanFarki = BitisZamani - BaslamaZamani;
            int FarkSaniye = ZamanFarki.Hours*3600+ZamanFarki.Minutes*60+ZamanFarki.Seconds;
            Console.WriteLine("Fark:"+FarkSaniye);
            Sure = (float)FarkSaniye;
            Ucret = Sure * SaniyeUcreti;
            BilgiYaz();
        }
        public void BilgiYaz()
        {
            Console.WriteLine("Sayin " + Kullanici.AdSoyad + "\n" + "Başlama Zamanı: " + BaslamaZamani + "\n" + "Bitiş Zamanı: " + BitisZamani + "\n" + "Toplam Süre: " + Sure + "\n" + "Toplam Ödemeniz Gereken Tutar: " + Ucret + "TL dir." + "\n" + "Kullandığınız Bisilet: " + Bisiklet.Marka + " " + Bisiklet.VitesSayisi + " vites" + "\n" + "İletişim Numaranız: " + Kullanici.Telefon);
        }


    }
}
