using System;

namespace _28._12._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            byte a = 5;
            short b = 10;
            sbyte c = 30;
            int d = a + b + c;
            string e = "deneme";
            char f = 'k';
            object g = e + f + d;
            long h = d;
            float i = h;
            double j = i;
            double k = 12.5f;
            Console.WriteLine(j+k);
            Console.WriteLine(g);
            */

            /*
              char a = 'h';                           //unicode karşılığını yazar. int ve char yüzünden.
              int b = a;
              Console.WriteLine(b);
            */
            /*
            byte a = 5, b = 10;
            short d = 2, e = 9;
            int f = a + b;
            int g = d + e;
            Console.WriteLine(f+g);
            */

            /*
             int a = 5;
             byte b = (byte)a;
             Console.WriteLine(b);
            */
            /*
            byte b = (byte)12.5f;
            Console.WriteLine(b);
            */
            /*
            int i = 250;                    //byte a çevirmeye çalışıyor fakat byte 255 ten fazla değer alamaz.255 yaparsan çalışır.
            byte b;
            checked
            {
                b = (byte)i;
            }
            Console.WriteLine(b);
            */
            /*
            int i = 255;
            int a = 300;
            byte b, c;
            checked
            {

                b = (byte)i;                //i 256 olarak atanmış olduğu için çalışma
                unchecked
                {
                    c = (byte)a;
                }
            }
            Console.WriteLine(b);
            Console.WriteLine(c);
            */
            /*
            object a = '5';             //object + sting olmalı yoksa ekleme yapamazsın
            string b = "4";
            Console.WriteLine(a+b);
            */
            /*
            object a = 'c';
            char b = (char)a;
            int c = (int)b;                             // c nin ascii kodunun karşılığı olur.
            Console.WriteLine(c);
            */
            // x.ToString()
            /* string b = 3.ToString();
             Console.WriteLine(b);
 *//*
            int a= 6;
            string b = a.ToString();
            Console.WriteLine(b);
*//*
            string b = 12.5f.ToString();
            Console.WriteLine(b);

*//*
            string b = 'k'.ToString();
            Console.WriteLine(b);
*//*
            string b = 5 + "deneme" + 'k' + 12.5f;
            Console.WriteLine(b);
*//*
            int a = 5;
            char b = 'k';
            string r = "deneme";
            float f = 12.5f;                    //a+b+r+f yaptığımızda 112deneme12,5 çıkarttı çünkü stringden önce gelen charın ascii sini aldı.
            string c = a + r + b + f;           //stringden önce gelenleri sayısal alır.
            Console.WriteLine(c);
*/
            /*
            string s1, s2;
            int sayi1, sayi2;
            int toplam;
            Console.Write("Birinci sayıyı giriniz:  ");
            s1 = Console.ReadLine();
            Console.Write("İkinci sayıyı giriniz:  ");
            s2 = Console.ReadLine();
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:  " + toplam);
            */
            /*
                        int i = 3 * 5 / 7;              //soldan sağa başlar. int olduğundan küsüratıo atıyor.float i = 3f * 5 / 7;  or double ile 3d
                       Console.Write(i);

                        int a = 3 * (5 / 7);              
                        Console.Write(a);
            */
            /*
                        int i = (int)(3f * (5f / 7f));              //nasıl 2 çıkıyor.
                        Console.WriteLine(i);
            */
            // MATEMETİKSEL OPERATÖRLER
            /*
            int i = 49% 2;
            Console.WriteLine(i);
            *//*
            float i = 5 / 2f;                   //float int ten daha büyük olduğundan float alınır.
            Console.Write(i);
            *//*
            float i = 2 / 5 / 2f;                   //  float i = 2 / 5f / 2;  0,2 çıkartır.
            Console.WriteLine(i);
            */

            //Bir arttırma Bir Eksiltme Operatörleri
            /*
                        int a = 5;
                        int i = ++a;                //ilk arttırır sonra atama yapar. 6 6 çıkartır.
                        Console.WriteLine(i+"  "+a);
            *//*
            int a = 5;
            int i = a++;
            Console.WriteLine(i + "  " + a);   //5 6 çıkartır. ilk atama yapar sonra arttırır.
*/
            /*
                        int a = 5;
                        int i = a++;            //a=6 i=5
                        int b = i--;            //b=5 i=4
                        int c = 10;             
                        int d = --c;            //d=9
                        Console.WriteLine("{0}\n{1}\n{2}\n{3}",a,i,b,d);
            */
            //Karşılaştırma operatörleri
            /* <küçüktür
             * >büyüktür
             * <= küçük eşittir
             * >= büyük eşittir
             * == eşit eşittir
             * != eşit değildir
 */
            /*
                      bool a = 4 < 6;
                      bool b = 6 > 5;
                      bool c = 7 <= 7;
                      bool d = 9 >= 12;
                      bool e = 10 == 12;
                      bool f = 1 != 8;
                      Console.Write($"{a}\n{b}\n{c}\n{d}\n{e}\n{f}\n");

          */
            /*
              object i = "50";
              string s = i as string;             //180.satırda yazan "50" ifadesi as string yapılmalı
              Console.WriteLine(s);
            */
            /* int i = 50;
             bool b1 = i is int;
             bool b2 = i is double;
             bool b3 = 12 is byte;
             bool b4 = 'c' is string;
             bool b5 = 12f + 7 is int;
             Console.WriteLine($" {b1}\n{b2}\n{b3}\n{b4}\n{b5}");
            */
            //  MANTIKSAL OPERATÖRLER
            /* bool b1 = 35 > 10 && 10 == 50;
             bool b2 = 35 > 10 && 10 != 50;
             bool b3 = 5 is int || 12*3 == 200;
             bool b4 = 5 < 4 || 45 / 5 == 9;
             bool b5 = !(5 < 4);
             Console.WriteLine(b1 + " " + b2 + " " + b3 + " " + b4 + " " + b5);
            */

            //  BİTSEL OPERATÖRLER

            /* byte a = 5 & 3;
              Console.WriteLine(a);
              byte b = 5 | 3;//00000101|0000001
  */
            /*
                        byte d = 5;
                        byte e = (byte)~d;
            */

            // ve 

            /*  byte b = 100;
              byte c = (byte)(b << 1);
              byte d = 50;
              byte e = (byte)(d >> 2);
              Console.WriteLine(c + "   " + d);
            */

            /*  byte b = 7, a = 1, c;
              c = a = b;
              Console.WriteLine(a + " " + b + " " + c + " ");*/
            /*  int a, b, c;
              a = 5;
              b = 6;
              a = a + b;          //a+=b dersek bununla aynı anlama gelir.
              Console.WriteLine(a);*/
            // ? KOŞUL OPERATÖRLERİ

            /*Console.WriteLine("Yazılımı seviyor musunuz? (E,H):");
            string DURUM = Console.ReadLine();
            Console.Write(DURUM == "e" ? "teşekkürler" : "sağlık olsun");
            */

            //EXAMPLES:

            //bir öğrencinin vize(%40) ve final(%60) notlarını klavyeden alıp genel notunu hesplayan program
            /*
                        string vize, final;
                        double svize, sfinal, sgenel,av,af;
                        Console.Write("VİZE NOTUNU GİRİNİZ:  ");
                        vize=Console.ReadLine();
                        svize = Convert.ToDouble(vize);

                        Console.Write("FİNAL NOTUNU GİRİNİZ: ");
                        final=Console.ReadLine();
                        sfinal = Convert.ToDouble(final);

                        av = svize *0.4;
                        af = sfinal * 0.6;                              /sgenel=(svize*0.4)+(sfinal*0.6);
                        sgenel = av + af;

                        Console.Write("GENEL ORTALAMA:  "+ sgenel);
            */

            //Klavyeden Fahrenayt olarak girilen sıcaklık bilgisini santigrat cinsine çevirip yazan program.
            /* string sfa;
             double fa, ca;
             Console.Write("Fahrenayt   : ");
             sfa=Console.ReadLine();
             fa = Convert.ToDouble(sfa);
             ca = (fa - 32) / 1.8;
             Console.WriteLine("Santigrat   : " + ca);
            */

            //hocamım yaptığı
            /*Console.Write("Fahrenayt bilgisi : ");
            string sFah = Console.ReadLine();
            double dFah = Convert.ToDouble(sFah);

            double dSan = (dFah - 32) / 1.8;
            dSan = Math.Round(dSan, 2); // virgülden sonra 2 basamak alır.

            Console.WriteLine($"{dFah} fahrenayt = > {dSan} santigrat derecedir.");
            *//*
            string sa, sb, sc;
            double a, b, c, toplam;
            Console.Write("Birinci sayıyı giriniz:  ");
            sa = Console.ReadLine();
            a = Convert.ToDouble(sa);
            Console.Write("İkinci sayıyı giriniz:  ");
            sb = Console.ReadLine();
            b = Convert.ToDouble(sb);
            Console.Write("Üçüncü sayıyı giriniz:  ");
            sc = Console.ReadLine();
            c = Convert.ToDouble(sc);
            toplam = a + b + c;
            Console.Write("\nToplam:  "+toplam+"\n\n");
            */

            /*  string ut, uy;
              double ta, yu, alan;
              Console.Write("ÜÇGENİN TABANI       :");
              ut=Console.ReadLine();
              ta = Convert.ToDouble(ut);
              Console.Write("ÜÇGENİN YÜKSEKLİĞİ   :");
              uy = Console.ReadLine();
              yu = Convert.ToDouble(uy);
              alan = (ta * yu) / 2;
              Console.WriteLine("ALANI                :"+alan);

  */
          /* double s1;
            string ss1;
            Console.WriteLine("--- TAHMİN OYUNU--- ");
            Console.Write("1-10 ARASI SAYI TUTTUM\n Tahmin et:   ");
            
            ss1 = Console.ReadLine();
            s1 = Convert.ToDouble(ss1);
            Console.Write(s1 == 5 ? "TEBRİKLER!!\n" : "TEKRAR DENE\n");
            bool a = s1 < 11 && s1 > 0;
            Console.WriteLine("Sayı aralığı  "+a);
            */
            
            
            
            //klavyeden girilen sayının çif tek olduğunu yazan program
            double s1;
            string ss1;

            Console.Write("SAYI GİRİNİZ:   ");
            ss1 = Console.ReadLine();
            s1 = Convert.ToDouble(ss1);
            Console.WriteLine(s1%2==0 ? "ÇİFT" : "TEK");
            

        }
    }
}
