using System;
using System.Collections.Generic;
using System.Text;

namespace Ders11_OOP_Encapsulation2
{
    class kuafor
    {

        enum Hizmetler
        {
            Sac_Trasi,
            Sakal_Trasi,
            Sac_Yikama,
            Cilt_Bakimi
        }
        class Kuafor
        {
            //enum hizmetler: Saç Traşı,Sakal Traşı,Saç Yıkama, Cit Bakımı
            //saçtr:20,sakal:15,saçyıkama:10,ciltbakımı:30
            //methodlar: SacTrasiYap(),SakalTrasiYap(),SacYika(),CiltBakimi()
            public int SacTrasiUcret { get; set; }
            public int SakalTrasiUcret { get; set; }
            public int SacYikamaiUcret { get; set; }
            public int CiltBakimiUcreti { get; set; }
            public Kuafor()
            {
                SacTrasiUcret = 20;
                SakalTrasiUcret = 15;
                SacYikamaiUcret = 10;
                CiltBakimiUcreti = 30;
            }
            private List<Hizmetler> alinanHizmet = new List<Hizmetler>();
            private float toplamUcret;
            public void SacTrasiYap()
            {
                alinanHizmet.Add(Hizmetler.Sac_Trasi);
                toplamUcret += SacTrasiUcret;
            }
            public void SakalTrasiYap()
            {
                alinanHizmet.Add(Hizmetler.Sakal_Trasi);
                toplamUcret += SakalTrasiUcret;
            }
            public void SacYikamaYap()
            {
                alinanHizmet.Add(Hizmetler.Sac_Yikama);
                toplamUcret += SacYikamaiUcret;
            }
            public void CiltBakimiYap()
            {
                alinanHizmet.Add(Hizmetler.Cilt_Bakimi);
                toplamUcret += CiltBakimiUcreti;
            }
            public void BilgiYaz()
            {
                Console.WriteLine("aşağıdaki hizmetleri aldınız:\n");
                foreach (var item in alinanHizmet)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("toplam tutar:" + toplamUcret);
            }
        }
    }
}

