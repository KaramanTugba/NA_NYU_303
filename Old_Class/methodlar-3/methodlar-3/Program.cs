using System;
using System.Collections.Generic;

namespace Ders_07_Metotlar_3
{
    class Program
    {
        static List<long> TCler = new List<long>();
        static List<string> adSoyadlar = new List<string>();
        static List<string> adresler = new List<string>();
        static List<string> telefonlar = new List<string>();

        static void Main(string[] args)
        {
            //Sayı Tahmin oyunu: 1'den 1000'e kadar bir sayı tutsun.
            //10 tahmin yaptırsın, küçük ise küçük oldu, büyük ise
            //büyük oldu desin. Tutturursa "Tebrikler tutturdunuz" desin.
            //10 tahminde bilemezse Tutturamadınız, sayı 657 idi,
            //Sayı Tahmin oyunu: 1'den 1000'e kadar bir sayı tutsun.
            //10 tahmin yaptırsın, küçük ise küçük oldu, büyük ise
            //büyük oldu desin. Tutturursa "Tebrikler tutturdunuz" desin.
            //10 tahminde bilemezse Tutturamadınız, sayı 657 idi,
            //Tahminleriniz 12 76 233 456 878 ... yazsın. 
            //Random rnd = new Random();
            //int rastgele = rnd.Next(65, 91);

            //int tahmin;
            //List<int> tahminler = new List<int>();
            //bool tutturdu = false;

            //////Console.WriteLine("Sayı=" + rastgele);

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Tahmin: ");
            //    int.TryParse(Console.ReadLine(), out tahmin);
            //    if (rastgele == tahmin)
            //    {
            //        Console.WriteLine("Tebrikler, " + i + ". tahminde bildiniz");
            //        tutturdu = true;
            //        break;
            //    }
            //    else if (rastgele > tahmin)
            //    {
            //        Console.WriteLine("Küçük oldu!");
            //        tahminler.Add(tahmin);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Büyük oldu!");
            //        tahminler.Add(tahmin);
            //    }

            //}
            //if (!tutturdu)
            //{
            //    Console.WriteLine("Malesef bilemediniz.Sayı=" + rastgele);
            //    Console.WriteLine("Tahminleriniz:");
            //    foreach (var item in tahminler)
            //    {
            //        Console.Write(item + " ");
            //    }
            //}
            //sayı tahmin oyunu(harfler ile)

            Random rnd = new Random();
            int rastgele = rnd.Next(65, 91);
            string rasgeleString = char.ConvertFromUtf32(rastgele);//ASCII 
            List<string> tahminler = new List<string>();
            bool tutturdu = false;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Tahmin: ");
                string tahmin = Console.ReadLine().ToUpper();
                int c = String.Compare(tahmin, rasgeleString);
                if (rasgeleString == tahmin)
                {
                    Console.WriteLine("Tebrikler, " + i + ". tahminde bildiniz");
                    tutturdu = true;
                    break;
                }
                else if (c==-1)
                {
                    Console.WriteLine("Küçük oldu!");
                    tahminler.Add(tahmin);
                }
                else
                {
                    Console.WriteLine("Büyük oldu!");
                    tahminler.Add(tahmin);
                }

            }
            if (!tutturdu)
            {
                Console.WriteLine("Malesef bilemediniz.Sayı=" + rastgele);
                Console.WriteLine("Tahminleriniz:");
                foreach (var item in tahminler)
                {
                    Console.Write(item + " ");
                }



                // 1-20 arasında rastgele 10'ar sayı üretip iki listeye atan ve daha sonra 
                // iki listede ortak olmayanları başka bir listeye atarak ekrana 
                // yazdıran program:
                // Örnek
                // Liste1 = 1 2 3 4 5 8 12 3 4 9
                // Liste2 = 2 3 11 13 15 8 5 6 7 9
                // Liste3 = 1 4 12 4 11 13 15 6 7
                // 
                //List<int> liste1 = new List<int>();
                //List<int> liste2 = new List<int>();
                //List<int> liste3 = new List<int>();
                //Random rand = new Random();
                //Console.Write("Liste1=" );
                //for (int i = 1; i <= 10; i++)
                //{
                //    int sayi = rand.Next(1, 21);
                //    liste1.Add(sayi);
                //    Console.Write(sayi  + " ");
                //}
                //Console.WriteLine();
                //Console.Write("Liste2=");
                //for (int i = 1; i <= 10; i++)
                //{
                //    int sayi = rand.Next(1, 21);
                //    liste2.Add(sayi);
                //    Console.Write(sayi + " ");
                //}
                //Console.WriteLine();

                //foreach (var item in liste1)
                //{
                //    if (liste2.Contains(item) == false)
                //        if(liste3.Contains(item) == false)  // Duplike olmasın diye. 
                //        liste3.Add(item);
                //}
                //foreach (var item in liste2)
                //{
                //    if (liste1.Contains(item) == false)
                //        if (liste3.Contains(item) == false) // Duplike olmasın diye. 
                //            liste3.Add(item);
                //}
                //Console.WriteLine("Birleşim Liste3=" );
                //foreach (var item in liste3)
                //{
                //    Console.Write(item + " ");
                //}

                //double r = 34.5;
                ////double pi = 3.14;
                //double cevre = CevreBul(r, 3.14);
                //Console.WriteLine(cevre);

                //Console.WriteLine(Topla());
                //Console.WriteLine(Topla(b:7));
                //Console.ReadLine();

                //Kendisine gönderilen double dizisini float dizisine çeviren
                // MakeItFloat isimli metodu yazınız. 
                //double[] d = new double[10] { 1.2,2.3,3.4,5,5,5,5,5,5,6};
                //float[] f = MakeItFloat(d);

                //foreach (var item in f)
                //{
                //    Console.Write(item + " ");
                //}

                // Liste içinde liste
                //List<object> listem = new List<object>();
                //List<int> sayilarim1 = new List<int> { 23, 34, 45, 77 };
                //List<int> sayilarim2 = new List<int> { 65, 54, 21 };

                //listem.Add(sayilarim1);
                //listem.Add(sayilarim2);
                //foreach (List<int> liste in listem)
                //{
                //    foreach (var item in liste)
                //    {
                //        Console.WriteLine(item);
                //    }
                //    Console.WriteLine();
                //}
                //Basit bir Personel Bilgi Sistemi:
                // TC(long), adSoyad string, adres string, telefon string için birer tane liste
                // tanımlayınız. PersonelIndexGetir(tc),PersonelEkleGuncelle(başarılı ise true döndür)
                // PersonelGetir: (TC veya adSoyad ile arama yapacak) tüm bilgileri tek string olarak döndür.
                //PersonelSil(tc): Remove edecek.
                //
                //Ödev: PersonelEkleGuncelle yi PersonelGuncelle ve PersonelEkle olarak yazınız. 

                //int index = personelındexgetir(67309105720);
                //console.writeline("index=" + index);
                //bool basarili = personelekleguncelle(tc: 67309105720,
                //                     adsoyad: "veysel perü",
                //                     adres: "sahrayıcedit/kadıköy...",
                //                     telefon: "05327741763");
                //basarili = personelekleguncelle(tc: 11111111112,
                //                   adsoyad: "ezgi",
                //                   adres: "bostancı...",
                //                   telefon: "05321111111");
                //basarili = personelekleguncelle(tc: 22222222222,
                //                   adsoyad: "şükrü",
                //                   adres: "sarıgazi...",
                //                   telefon: "05322222222");
                //basarili = personelekleguncelle(tc: 3333333333,
                //                   adsoyad: "uğur okan",
                //                   adres: "bağcılar...",
                //                   telefon: "05323333333");
                //basarili = personelekleguncelle(tc: 44444444444,
                //                   adsoyad: "melike",
                //                   adres: "beşiktaş...",
                //                   telefon: "05324444444");
                //index = personelındexgetir(67309105720);
                //console.writeline("index=" + index);

                //basarili = personelekleguncelle(tc: 67309105720,
                //                     telefon: "0555 5555555");
                //for (int i = 0; i < tcler.count; i++)
                //{

                //    console.writeline(tcler[i]);
                //    console.writeline(adsoyadlar[i]);
                //    console.writeline(adresler[i]);
                //    console.writeline(telefonlar[i]);

                //}
                //console.writeline(personelgetir(tc: 67309105720));
                //basarili=personelsil
                //console.writeline(personelgetir(tc: 67309105720, adsoyad: "ezgi123"));
                //string p = personelgetir(tc: 67309105720, adsoyad: "ezgi");

                //console.readline();
            } // main sonu 
        }
    }
}

//        static string personelgetir(long tc = 0, string adsoyad = "")
//        {
//            int personelındex = -1;
//            string personel = "";
//            if (adsoyad != "") personel = "ad soyad " + adsoyad + " bulunamadı";
//            if (tc != 0) personel = "tc " + tc + " bulunamadı";
//            if (tc != 0)
//            {
//                personelındex = tcler.ındexof(tc);//personelındexgetir(tc);
//            }
//            else
//            {
//                personelındex = adsoyadlar.ındexof(adsoyad);
//            }
//            if (personelındex != -1)
//            {
//                personel = convert.tostring(tcler[personelındex]) + " " +
//                    adsoyadlar[personelındex] + " " +
//                    adresler[personelındex] + " " +
//                    telefonlar[personelındex];
//            }
//            return personel;
//        }

//        static int personelındexgetir(long tc)
//        {
//            int personelındex = -1;
//            if (tcler.contains(tc))
//            {
//                personelındex = tcler.ındexof(tc);
//            }
//            return personelındex;
//        }
//        static bool personelsil(long tc)
//        {
//            if (tc>0)
//            {
//                int index = personelındexgetir(tc);
//                if(index!=-1)
//                {
//                    tcler.removeat(index);
//                    adsoyadlar.removeat(index);

//                }
//            }
//        }

//        private static bool personelekleguncelle(long tc = 0, string adsoyad = "", string adres = "", string telefon = "")
//        {
//            int personelındex = -1;
//            if (tc < 10000000000 || tc > 99999999999)
//            {
//                console.writeline("tc formatı yanlış. (" + tc + ")  entera basınız.");
//                console.readline();
//                return false;
//            }
//            if (tc == 0)
//            {
//                console.writeline("tc sıfır olamaz. entera basınız.");
//                console.readline();
//                return false;
//            }
//            else
//            {
//                personelındex = personelındexgetir(tc);
//                if (personelındex == -1)       // personel yok, o zaman ekleyeceğiz.
//                {
//                    if (adsoyad == "")
//                    {
//                        console.writeline("ad soyad boş olamaz. entera basınız.");
//                        console.readline();
//                        return false;
//                    }
//                    tcler.Add(tc);
//                    adsoyadlar.Add(adsoyad);
//                    adresler.Add(adres);
//                    telefonlar.Add(telefon);
//                }
//                else   // tc var, o zaman güncelle!
//                {
//                    if (adsoyad != "") adsoyadlar[personelındex] = adsoyad;
//                    if (adres != "") adresler[personelındex] = adres;
//                    if (telefon != "") telefonlar[personelındex] = telefon;
//                }
//            }
//            return true;
//        }

//        static float[] makeıtfloat(double[] doublearray)
//        {
//            float[] floatarray = new float[doublearray.Length];
//            for (int i = 0; i < doublearray.Length; i++)
//            {
//                floatarray[i] = (float)doublearray[i];
//            }
//            return floatarray;
//        }

//        static int[] makeıtınt(double[] doublearray)
//        {
//            int[] intarray = new int[doublearray.Length];
//            for (int i = 0; i < doublearray.Length; i++)
//            {
//                intarray[i] = (int)doublearray[i];
//            }
//            return intarray;
//        }

//        static double cevrebul(double r, double pi = 3.14159275358)
//        {
//            return r * pi;
           
//        }
//        static double topla(int a = 10, int b = 20)
//        {
//            return a + b;
            
//        }
//    }
//}
