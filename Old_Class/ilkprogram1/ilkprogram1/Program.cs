using System;

namespace ilkprogram1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                int bSayiMax = int.MaxValue;
                int bSayiMin = int.MinValue;
                Console.WriteLine($"byte tipinin alabileceği en büyük değer:  { bSayiMax}");
                Console.WriteLine($"byte tipinin alabileceği en küçük değer:  { bSayiMin}");
              */
            /*  uint bsayimax = uint.MaxValue;
              uint bSayiMin = uint.MinValue;
              Console.WriteLine($"byte tipinin alabileceği en büyük değer:  { bsayimax}");
              Console.WriteLine($"byte tipinin alabileceği en küçük değer:  { bSayiMin}"); 
            */
            //  string a = "it is me Monica, Rachel";
            //Console.WriteLine(a);

            /*char a = 'a';
            string b = "deneme";
            string c = a + b + "sınıf" + 'm';
            Console.WriteLine(c);*/

            /*  bool b1 = true;
              bool b2 = false;
              bool b3 = 5 > 4;
              Console.WriteLine(b3);
            */
            /*
                        object a = 10;
                        object b = 'k';
                        object c = "metin";
                        object d = 129.9f;
            */

            /*string a = "5";
            string b = "8";
            Console.WriteLine(a + b);
*/
            /*
                        string a;
                        a = Console.ReadLine();
                        Console.WriteLine(a + "  metnini yazdınız.");

            */
            /*
            int a, b;
            a = 20;
            b = a+1;
            Console.WriteLine(b);
            */


            /*   const int a = 5;
               const string b =" deneme"; // sbit tanımlama
               const char c = '  s';

               */

            /*   string ad = "deneme\"deneme";      // çift tırnak olduğundan, programa hata vermemsisi için yapmamız gereken \ dür.
               Console.WriteLine(ad);
            */
            /*
            string a = "asda";
            string b = "gaga";
            string c = "dfgefweewew";
            */

            // Console.WriteLine("SATIR\nYENİ SATIR");
            /*
                        Console.WriteLine(5.GetType());
                        Console.WriteLine(14.4.GetType());
                        Console.WriteLine("deneme".GetType());
                        byte a = 2;
                        Console.WriteLine();
                        */
            /*
            Console.Write("AD SOYAD GİRİNİZ:      ");
            //var a = Console.ReadLine(); Değişken atanarak yapılır.
            Console.WriteLine(Console.ReadLine() +"      HOŞGELDİNİZ");     // Değişken atanmadan yapılır.

*/

            // Ad soyad parola eposta yazdıran 

            /*   Console.Write("AD SOYAD      :");
               var a = Console.ReadLine();
               Console.Write("EPOSTA      :");
               var b = Console.ReadLine();
               Console.Write("PAROLA      :");
               var c = Console.ReadLine();
               Console.WriteLine($"{a}\n{b}\n{c}");
            */

            /* 
              var a = 4444.4f;
              Console.WriteLine(a.GetType());
            */

            /* 
             bool sayi1 = true;
             bool sayi2 = false;
             bool sayi3 = 5 * 8 == 47;
             Console.WriteLine(sayi3);
            */
            /*
             char a ='1';
             string b=".metin";
             string c = a + b;
             Console.WriteLine(c);

             char f = '7';
             string g = "kitap yazdı, şimdiye kadar...";
             string h =  f+" "+g;
             Console.WriteLine(h);
            */

            //2 string değişkeni int değere (    PROGRAM ÇALIŞMAZ  )
            /*
             string a= "5";
             string b = "10";
             int c = ('a'+'b');
             Console.WriteLine(c);
 */
            //   Console.WriteLine("DENEME \"örnek\" deneme");   

            /* Console.Write("İlk ifadeyi giriniz :");
             var a = Console.ReadLine();
             Console.Write("İkinci ifadeyi giriniz :");
             var b = Console.ReadLine();
             Console.Write("Üçüncü ifadeyi giriniz :");
             var c = Console.ReadLine();
             Console.WriteLine("SONUÇ : "+a + "  " + b + "  " + c);
         */

            /*string yol = @"dkhflkef///\\\efkjewje..!!!'''";
             Console.WriteLine(yol);*/

            string a = "hi";
            int b =2;
            float c =1.4f;
            char d='g';
            Console.WriteLine("1.ifade :" + a.GetType()+"\n2.ifade :"+b.GetType()+"\n3.ifade: "+c.GetType()+"\n4.ifade :"+d.GetType()) ;
        }
    }
}
