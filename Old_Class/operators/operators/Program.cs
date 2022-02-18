using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double a, b, c, d, sonuc1, sonuc2, sonuc3;
            a = 5;
            b = 10;
            c = 20;
            d = 30;
            sonuc1 = a * b / c + d;
            Console.WriteLine("Sonuç : "+sonuc1);
            sonuc2 = a * b / (c + d);
            Console.WriteLine("Sonuç 2 : "+sonuc2);
            short miktar = 10;
            double miktarr = 10 % 4;
            miktar += 5; //miktarın var olan değerine 5 ekler. miktar=miktar+5;
            Console.WriteLine("Miktar : "+miktar);
            miktar -= 6; //miktarın var olan değerinden 6 çıkatır. miktar=miktar-6;
            Console.WriteLine("Miktar : " + miktar);
            miktar *= 3; //miktarın var olan değeri ile 3 ü çarpar. miktar=miktar*3;
            Console.WriteLine("Miktar : " + miktar);
            miktar /= 4; //miktarın var olan değerini 4e böler. miktar=miktar/4;
            Console.WriteLine("Miktar : " + miktar);
            Console.WriteLine("Miktarr : "+miktarr);
            *//*
            byte miniksayi = 76;
            miniksayi++;
            ++miniksayi;
            Console.WriteLine("Minik sayı : "+miniksayi.ToString());
            *//*
            byte ikincisayi = ++miniksayi;
            ikincisayi=miniksayi++;
            Console.WriteLine("ikinci sayı : "+ikincisayi.ToString());
            Console.WriteLine("Minik sayı : " + miniksayi.ToString());
            int deger1 = 8;
            int deger2 = deger1++;// deger 2= 8; deger1=9 olur.
            Console.WriteLine("deger1 : "+deger1.ToString());
            Console.WriteLine("deger2 : " + deger2.ToString());
            */
            // < > == !=
            /*
            int s1 = 90;
            int s2 = 99;
            bool s1_buyuk_s2 = (s1 > s2);//false
            if(s1_buyuk_s2)
                Console.WriteLine("s1 buyuk s2");
            else if(s1<s2)
                Console.WriteLine("s1 küçük s2");
            else if(s1==s2)
                Console.WriteLine("s1 eşittir s2");
            else
                Console.WriteLine("yanlış döndü");
            //s1 = s2; //atama yapar.
            */
            // as is
            /*
            object obj="veysel";
            string yazi = obj as string;
            Console.WriteLine(yazi);
            //Console.WriteLine(yazi.GetType());

            bool intmi = yazi is int;
            Console.WriteLine("intmi = "+intmi.ToString());

            bool stringmi = yazi is string;
            Console.WriteLine("stringmi = " + stringmi.ToString());
            */
            //      && || !  Mantıksal Operatörler

            /*
            int sayi = 77;
            bool sayiKontrol = sayi <= 100 && sayi >= 0; //İki koşulda sağlanırsa true.
            Console.WriteLine("SAYI KONTOL : "+sayiKontrol);
            */
            /*
            int sayi = -5;
            bool notgecerlimi = sayi <= 100 && sayi >= 0; //İki koşulda sağlanırsa true.
            if (!notgecerlimi)
                Console.WriteLine("Not geçerli değil : " + notgecerlimi);
            else
                Console.WriteLine("Not geçerli : "+notgecerlimi);
            */
            int s3 = 45;
            bool kontr = !(s3 != 55 && s3 < 78);

            //Bitsel operatörler & | ~ 

            byte bsayi = 5; //0101
            byte isayi = 1; //0001
            int sonuc4 = bsayi | isayi;
            Console.WriteLine("sonuç4 = " + sonuc4);

            uint a5 = 65;
            uint b5 = ~a5;
            Console.WriteLine(Convert.ToString(b5, toBase: 2)); //2lik birime dönüştürülmüş halini yazar.

            // Bitsel sağa kaydırma >> (2 ye böler)  << (2 ile çarpar)
            byte bs = 6;
            byte bs2 = (byte)(bs << 1);
            Console.WriteLine("bs2 = " + bs2);





















            Console.Read();
        }
    }
}
