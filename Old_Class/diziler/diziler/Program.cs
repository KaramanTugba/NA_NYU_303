using System;
using System.Linq;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*// tip[] diziadi=new tip[boyut] ;
            // int[] sayilar=new int[10] ;
            // int[] rakamlar={0,1,2,3,4,5,6,7,8,9};
            // intrakamlar=new int[10];

            // int[] sayilar=new int[10] ;
            // indis numaraları 0'dan başlar, birer birer artarak devam eder.

            string[] isimler = new string[5];
            isimler[0] = "AHMET";
            isimler[1] = "ALİ";
            isimler[2] = "AYŞE";
            isimler[3] = "VELİ";
            isimler[4] = "EDA";

            int[] rakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            rakamlar[1]= 100;
            rakamlar.SetValue(130, 0); //ilk elemana 130 atar.
            Console.WriteLine("rakamlar[1]: " + rakamlar.GetValue(1));
            Console.WriteLine("rakamlar[0]: " + rakamlar[0]);
            Console.WriteLine("rakamlar.GetType(): "+rakamlar.GetType());
            Console.WriteLine("rakamlar.Length: "+rakamlar.Length);
            // rakamlar[10] = 100; //index out of range hatası.
            
            for(int i=0;i<isimler.Length;i++)
                Console.WriteLine("isimler["+i+"]: "+isimler[i]);
            Console.WriteLine("\n");
            
            for (int i = 0; i < isimler.Length; i++)
                Console.WriteLine("isimler[" + i + "]: " + isimler.GetValue(i));
            Console.WriteLine("\n");
            
            string[] sehirler = { "adana", "adıyaman", "afyon", "ağrı", "amasya" };
            for (int i = 0; i < sehirler.Length; i++)
                Console.WriteLine("sehirler[" + i + "]: " + sehirler[i]);
            Console.WriteLine("\n");
           
            //foreach for ile benzer iş yapar, indis yerine doğrudan şehir bilgisine ulaşır.
            int k = 0;
            foreach(var item in sehirler)
            {
                Console.WriteLine("sehirler[" + k + "]: " + item);
                k++;
            }
            //iki array yaratma.
            string[] mySourceArray = new string[10];
            mySourceArray[0] = "yuvalarında";
            mySourceArray[1] = "uyuyan";
            mySourceArray[2] = "üç";
            mySourceArray[3] = "uykulu";
            mySourceArray[4] = "tavuğun";
            mySourceArray[5] = "5";
            mySourceArray[6] = "6";
            mySourceArray[7] = "7";
            mySourceArray[8] = "8";
            mySourceArray[9] = "9";

            string[] myTargetArray = new string[15];
            myTargetArray[0] = "çevik";
            myTargetArray[1] = "kahverengi";
            myTargetArray[2] = "tilki";
            myTargetArray[3] = "atladı";
            myTargetArray[4] = "üstüne";
            myTargetArray[5] = "tembel";
            myTargetArray[6] = "köpeğin";

            foreach (var item in myTargetArray)
            {
                Console.WriteLine(item);
            }
            mySourceArray.CopyTo(myTargetArray, 5);
            Console.WriteLine("\n");

            for (int i = 0; i < mySourceArray.Length; i++)
            {
                Console.WriteLine(i + " " + mySourceArray[i]);
            }
            Console.WriteLine("\n");
            foreach (var item in myTargetArray)
            {
                Console.WriteLine(item);
            }

            int indis = Array.IndexOf(sehirler, "adana", 2);
            Console.WriteLine("indis: "+indis);
            */
            // kullanıcıdan alınan 10 adet isim bilgisini diziye atayıp yazdıran program.
            /* string[] isimler = new string[10];
             int i;
             for (i = 0; i < 10; i++)
             {
                 Console.WriteLine("isim yazın");
                 string isim = Console.ReadLine();
                 isimler[i] = isim;
             }
             Console.Write("isimler dizisi : ");
             foreach (var item in isimler)
             {
                 Console.Write(item + " ");
             }
             Console.WriteLine("\n");
             for (int a = 0; a < isimler.Length; a++)
             {
                 Console.WriteLine("isimler[" + a + "]:" + isimler[a]);
             }
            */
            /*
             Console.WriteLine("\n");

             int[] puanlar = { 10, 20, 30, 40, 10, 14, 10, 20, 30, 90 };
             Console.WriteLine("puanlar.Length: "+puanlar.Length);
             int indis = Array.IndexOf(puanlar, 10);//0 gelir
             //indexof o sayıdan itibaren söylenen sayıyı arar. [0] ile başlar.
             indis = Array.IndexOf(puanlar, 10,1);//4gelir
             indis = Array.IndexOf(puanlar, 10,5);//6gelir
             indis = Array.IndexOf(puanlar,20);//1gelir
             Console.WriteLine("indis= "+indis);

             Console.WriteLine("\n");

            // Array.Sort(puanlar); // küçükten büyüğe sıralar.
             Array.Reverse(puanlar); //diziyi tersine çevirir.
             foreach(int item in puanlar)
             {
                 Console.WriteLine(item);
             }
             string[] sehirler = { "adana", "adıyaman", "afyon", "ağrı", "amasya","radana" };
             Array.Sort(sehirler); //alfabetik sıraya göre
             Array.Reverse(sehirler); //diziyi tersine çevirir.
             foreach (string item in sehirler)
             {
                 Console.WriteLine(item);
             }
            */
            /* object[] karisikdizi = new object[10];
            karisikdizi[0] = 10;
            karisikdizi[1] = "ayşe";
            karisikdizi[2] = 15.4f;
            karisikdizi[3] = 16.123d;
            foreach (object item in karisikdizi)
            {
                Console.WriteLine(item);
            }
            object eleman = "ayşe";
            int indis = Array.IndexOf(karisikdizi, eleman);
            Console.WriteLine("indis : "+indis);
         
            Console.WriteLine("\n");

            int[] ar = new int[10]; //int olduğu için 0 yazdırır boşluk yerine.
            ar[0] = 123;
            ar[9] = 124;
            foreach (int arra in ar)
            {
                Console.WriteLine(arra);
            }
            Console.WriteLine("indexof= "+Array.IndexOf(ar,0,3)); // üçüncü elemandan itibaren başlar bakmaya
            eleman = 15.4;
            indis = Array.IndexOf(karisikdizi, eleman);
            Console.WriteLine("ındexof: "+Array.IndexOf(karisikdizi,0));
*/
            /* //1-10 arası rasgele 10 sayı üretip bir diziye atın,sonrada diziyi ekrana yazdırın.

             Random rastgele = new Random();
             int[] arraysayilar = new int[1000];
                 for(int i=0;i<arraysayilar.Length;i++)
             {
                 arraysayilar[i] = rastgele.Next(1,10);//0-10 verirsek 0dan 9 a kadar sayı verir

             }
             int sayac = 0;
             int count7 = 0;
             int cc = 0;
             foreach (var item in arraysayilar)
             { Console.Write(item+" ");
                 sayac++;
                 if(sayac%10==0)
                 { Console.WriteLine(""); }
                 if(item==7)
                 {
                     count7++;
                 }
             }
             cc = arraysayilar.Count(x => x % 3 == 0);
             //count7 = arraysayilar.Count(sayi => sayi == 7);
            // cc = arraysayilar.Count(sayi => sayi == 5);
             //Console.WriteLine("7 sayısının adedi : " + count7);
             Console.WriteLine("3 ebölünebilen sayısının adedi : "+cc);
            // Console.WriteLine("arraysayilar.count() :" + arraysayilar.Count());
           */
            //10 sayısının dizide hangi indislerde olduğunu gösteren program.
            /*
            int[] puanlar = { 10, 20, 30, 40, 10, 14, 10, 20, 30, 90 };
            int startindex = 0;
            int adet10 = puanlar.Count(sayi => sayi == 10);
            for(int i=0;i<adet10;i++)
            {
                startindex = Array.IndexOf(puanlar, 10, startindex);//puanlar içinde 10 değerini arattır. startindexten başla.
                Console.WriteLine("10 değeri "+startindex+". indexte var.");
                startindex += 1;
            }
            Console.WriteLine("**************************************************");
            for(int i=0;i<puanlar.Length;i++)
            {
               if(puanlar[i]==10)
                {
                    Console.WriteLine("10 değeri "+i+".indexte var");
                }
            }*/
            //rastgele yapılan diziden 100 kaçıncı indexte bulan program.
            /*
                       // int[] puanlar = { 10, 20, 30, 40, 10, 14, 10, 20, 30, 90 };
                        int[] puanlar = new int[100000];
                        Random ran = new Random();
                        for (int i = 0; i < puanlar.Length; i++)
                        {
                            puanlar[i] = ran.Next(1, 100);
                        }

                        int startIndex = 0;
                        int adet10 = puanlar.Count(sayi => sayi == 10);
                        for (int i = 0; i < adet10; i++)
                        {
                            startIndex = Array.IndexOf(puanlar, 10, startIndex);//puanlar içinde
                            // 10 değerini arattır, startIndex ten başla. 
                            Console.WriteLine("10 değeri " + startIndex + ". indexte var");
                            startIndex += 1;
                        }
            
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < puanlar.Length; i++)
            {
                if (puanlar[i] == 10)
                    Console.WriteLine("10 değeri " + i + ". indexte var");
            }
            */
            /*
            // Arraydeki çift sayıların ve tek sayıların adedi.
            int[] sayilar = { 1, 2, 3, 4, 3, 55, 23, 2, 5, 6, 2, 4, 9, 12, 7, 3 };
            int ciftSayilarinSayisi = sayilar.Count(c => c % 2 == 0);
            Console.WriteLine("ciftSayilarinSayisi=" + ciftSayilarinSayisi); //6
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0)
                    Console.WriteLine(sayilar[i] + " ");
            }

            int tekSayilarinSayisi = sayilar.Count(t => t % 2 == 1);
            Console.WriteLine("tekSayilarinSayisi=" + tekSayilarinSayisi);

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 1)
                    Console.WriteLine(sayilar[i] + " ");
            }
           *//*
            int countc = 0;
            int countt = 0;
            int[] rasa = new int[100];
            Random ran = new Random();
            for (int i = 0; i <rasa.Length; i++)
            {
               rasa[i] = ran.Next(1, 100);
            }
            Array.Sort(rasa);
            for(int i=0;i<rasa.Length;i++)
            {
                if (rasa[i] % 2 == 0)
                {
                    Console.WriteLine(rasa[i] + " ");
                    countc++;
                }
            }
            Array.Sort(rasa);
            Array.Reverse(rasa);
            Console.WriteLine("******************************");
            Array.Sort(rasa);
            Array.Reverse(rasa);
          


            for (int i = 0; i < rasa.Length; i++)
            {
                if (rasa[i] % 2 == 1)
                {
                    Console.WriteLine(rasa[i] + " ");
                    countt++;
                }
            }

            Console.WriteLine("çifler :"+countc+" tekler :"+countt);
            */
            //diziden diziye kopyalama
            /*
             int[] dizi1 = { 11, 41, 21, 32, 43, 54, 65, 66, 77, 86 };
             int[] dizi2 = new int[dizi1.Length];
             dizi1.CopyTo(dizi2, 0);//dizi2 nin 0 elemanından başlayarak
             for(int i=0;i<dizi1.Length;i++)
             {
                 Console.WriteLine(dizi2[i]);
             }

             */

            //20 elemanlı array,içine 1-20 kadar sayı at. 5bölüce kaç kalırsa yıldız yazılsın.

            int[] rasa = new int[20];
            Random ran = new Random();
            for (int i = 0; i < rasa.Length; i++)
            {
                rasa[i] = ran.Next(1, 20);
            }
            for (int i = 0; i < rasa.Length; i++)
            {
                if (rasa[i] / 5 == 1)
                {
                    Console.WriteLine(rasa[i] + "*");
                }
                else if (rasa[i] / 5 == 2)
                {
                    Console.WriteLine(rasa[i] + "**");
                }
                else if (rasa[i] / 5 == 3)
                {
                    Console.WriteLine(rasa[i] + "***");
                }
                else if (rasa[i] / 5 == 4)
                {
                    Console.WriteLine(rasa[i] + "****");
                }
                else
                    Console.WriteLine(rasa[i] + " ");

            }

            //hocanın yapışı

            int[] dizi3 = new int[20];
            Random rnd3 = new Random();
            for (int i = 0; i <20; i++)
                dizi3[i] = rnd3.Next(1, 21);
            for (int i = 0; i < 20; i++)
            {
                Console.Write(dizi3[i] + "--->");
                for (int j = 0; j < dizi3[i] % 5; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }









        }
    }
}
