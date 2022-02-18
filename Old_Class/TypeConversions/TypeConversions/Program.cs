using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {


            // BİLİNÇSİZ TÜR DÖNÜŞÜMÜ

            // Küçük tür, büyük türe otomatik olarak dönüştürülür.
            /*
                        byte byteSayi = 58;
                        int intSayi = byteSayi;
                        int ii = 60000;
                        //byte bb = ii; //Hata veriyor.
                        float fsayi = 29.45f;
                        double dSayi = fsayi;

                        double dSayi2 = fsayi;
                        // float fsayi2 = dSayi2; //Hata veriyor.
            */

            //  KASITLI TÜR DÖNÜŞÜMÜ ( CASTİNG )
            /*
            checked
            {
                double doublesayi6 = 305;
                byte bytesayi6 = (byte)doublesayi6;
                Console.WriteLine("bytesayi6 = " + bytesayi6);
            }
            */

            //  CONVERT SINIFI İLE TÜR DÖNÜŞÜMÜ
            /*
                        double ddd = 678.455d;
                        string str = Convert.ToString(ddd);
                        Console.WriteLine("str dönüşümü: "+str);

                        string str2 = "14474";
                        int ddd2 = Convert.ToInt32(str2);
                        Console.WriteLine("Int dönüşümü : "+ddd2);
            */
            // examples:         Klavyeden Fahrenheit olarak girilen sıcaklık bilgisini c çevir.
            /*
            double sonuc;

            Console.Write("Fahreheit : ");
            double c = Convert.ToDouble(Console.ReadLine());
            sonuc = (c - 32) / 1.8;
            Console.Write("\nC : "+ sonuc);
            double sonuc;*/
            /*
            Console.Write("Fahreheit : ");
            double c = Convert.ToDouble(Console.ReadLine());
            sonuc = (c - 32) / 1.8;
            sonuc = Math.Round(sonuc,2);//virgülden sonraki 2 basamağı da alır.
            Console.Write("\nC : " + sonuc);
            */
            /*
            char krtr1 = 'A';
            int sayi8 = Convert.ToInt32(krtr1);
            Console.WriteLine("sayi 8 = " + sayi8.ToString());
            */

            //girilen iki sayının toplamının karesi.
            /*
                        int s1, s2,kare,sonuc;
                        Console.Write("1.sayı giriniz: ");
                        s1=Convert.ToInt32(Console.ReadLine());
                        Console.Write("2.sayı giriniz: ");
                        s2 = Convert.ToInt32(Console.ReadLine());
                        sonuc = s1 + s2;
                        sonuc *= sonuc;
                        Console.WriteLine("kareler toplamı : "+sonuc+" dır.");
            */
            /*
             Console.WriteLine("birinci sayı giriniz: ");
             double i1sayi = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("ikinci sayı giriniz : ");
             double i2sayi = Convert.ToDouble(Console.ReadLine());
             double i3sayi = (i1sayi + i2sayi);
             double sonuc2;
             sonuc2 = (int)Math.Pow (i3sayi, 2);
             Console.WriteLine(i1sayi + " ve " + i2sayi + " sayıların toplamının karesi "+sonuc2);
 */
            /*
                        //klavyeden alınan sayı 5 ten büyükse sayının kendisini,değilse 
                        int ss1=0;
                        Console.Write("sayıyı giriniz. : ");
                        int s1 = Convert.ToInt32(Console.ReadLine());
                        if (s1 > 5)
                        { Console.WriteLine("Sayı : " + s1); }
                        /* else if (s1 < 5)
                         {
                             ss1 = s1 * s1;
                             Console.WriteLine("Sayı : " + ss1);
                         }
                         else if(s1==5)
                             Console.WriteLine("5 e eşittir.");
                         else

                        else
                            Console.WriteLine("5 ten küçük yada eşittir. " + Math.Pow(s1, 2));
                   Console.WriteLine("yanlış girdiniz.");
                        */
            /*
                        Console.WriteLine("1.sayı :");
                        int s1=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("2.sayı :");
                        int s2 = Convert.ToInt32(Console.ReadLine());
                        if (s1 > s2)
                            Console.WriteLine("büyük sayı :" + s1);
                        else if (s1 < s2)
                            Console.WriteLine("büyük sayı :" + s2);
                        else if (s1 == s2)
                            Console.WriteLine(s1 + " ve " + s2 + " birbirine eşittir.");
                        else
                            Console.WriteLine("null döndü");
            */
            /*telefona kaydettim
             * int top = 0;
             Console.WriteLine("1.sayı : ");
             int s1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("2.sayı : ");
             int s2 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("3.sayı : ");
             int s3 = Convert.ToInt32(Console.ReadLine());
             if (s1 < 100)
                 Console.WriteLine(s1);
             if (s2 < 100)
                 Console.WriteLine(s2);
             if (s3 < 100)
                 Console.WriteLine(s3);
             top = s1 + 2 + s3;
             Console.WriteLine(top);
             else if (s1 > 100 || s2 > 100 || s3 > 100)
                 Console.WriteLine("büyük sayı girildi.");
             else
                 Console.WriteLine("")
            */
            //girilen nota göre harfi vermek.
            /* char f = 'F';
             char d = 'D';
             char c = 'C';
             char b = 'B';
             char a = 'A';
             string s1;
             Console.WriteLine("not giriniz :");
             s1 = Console.ReadLine();
             int n1 = Convert.ToInt32(s1);
             if(n1>=0 && n1<=49)
                 Console.WriteLine("not : "+f);
            else if (n1 >= 50 && n1 <= 64)
                 Console.WriteLine("not : " + d);
             else if (n1 >= 65 && n1 <= 74)
                 Console.WriteLine("not : " + c);
             else if (n1 >= 75 && n1 <= 84)
                 Console.WriteLine("not : " + b);
             else if (n1 >= 85 && n1 <= 100)
                 Console.WriteLine("not : " + a);
             else
                 Console.WriteLine("100 den büyük olamaz.");
             */
            // klavyeden girilen 2 sayı ve işaretten işlem yapılmasını sağlayan program
            /*
            int top = 0;
            Console.WriteLine("1.sayı : ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("işlemi al (+ - * / )");
            string isaret = Console.ReadLine();
            Console.WriteLine("2.sayı : ");
            int s2 = Convert.ToInt32(Console.ReadLine());
            

            if (isaret == "+")
            {
                top = s1 + s2;
                Console.WriteLine(top);
            }
            else if (isaret == "-")
            {
                top = s1 - s2;
                Console.WriteLine(top);
            }
            else if (isaret == "*")
            {
                top = s1 * s2;
                Console.WriteLine(top);
            }
            else if (isaret == "/")
            {
                if (s2 == 0)
                    Console.WriteLine("payda sıfır olamaz.");
                else
                {
                    
                        top = s1 / s2;
                    Console.WriteLine(top);
                }

            }
            else
                Console.WriteLine("işaret yanlış");
*/         /*
            int b = 0;
            int a=0;
            Console.WriteLine("sayı gir");
            int s1 = Convert.ToInt32(Console.ReadLine());
            if (s1 % 2 == 0)
                Console.WriteLine("çifttir " + s1);
            else if (s1 % 3 == 0)
            {
                a = s1 / 3;
                Console.WriteLine("say 3 ün" + a + " katıdır");
            }
            else
            {
                b = s1 % 3;
                Console.WriteLine("2 ve 3 ün katı değil kalan" + b + "dır");
            }


            */
            //klavyeden 
            int nltop = 0;
            int pltop = 0;
            int ntop = 0;
            int ptop = 0;
            int isaretsiz = 0;

            Console.WriteLine("1.sayı :");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı :");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.sayı :");
            int s3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("4.sayı :");
            int s4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("5.sayı :");
            int s5 = Convert.ToInt32(Console.ReadLine());

            if (s1 > 0)
            {
                ptop++;
                pltop += s1;
            }
            else if (s1 == 0)
                isaretsiz++;
            else
            { ntop++;
                nltop += s1;
            }
            if (s2 > 0)
            {
                ptop++;
                pltop += s2;
            }
            else if (s2 == 0)
                isaretsiz++;
            else
            { ntop++;
                nltop += s2; }
            if (s3 > 0)
            {
                ptop++;
                pltop += s3;
            }
            else if (s3 == 0)
                isaretsiz++;
            else
            { ntop++;
            nltop += s3; }
            if (s4 > 0)
            {
                ptop++;
                pltop += s4;
            }
            else if (s4 == 0)
                isaretsiz++;
            else
            { ntop++;
                nltop += s4;
            }
            if (s5 > 0)
            {
                ptop++;
                pltop += s5;
            }
            else if (s5 == 0)
                isaretsiz++;
            else
            {
                ntop++;
                nltop += s5;
            }

                Console.WriteLine("negatif top"+nltop+"pozitif top"+pltop);
            Console.WriteLine("negatif: " + ntop + " pozitif: " + ptop + "isaretsiz :" + isaretsiz);












            Console.Read();
        }
    }
}
