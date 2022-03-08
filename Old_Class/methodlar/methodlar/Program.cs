using System;

namespace methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            MerhabaDunya("ezgi");
           
            //2 sayının toplamını yazdıran methot
            int toplam = buyukolani(88, 99);
            Console.WriteLine(topla(88, 99));
            Console.WriteLine(buyukolani(88,99));
            Console.WriteLine(Karesi(4));
            Console.WriteLine(BuyukOlaniDondur(125,87,41));

            //kendisine gönderilen fiyata %18 kdv ekleyip geri döndüren methodu yazınız.
            Console.WriteLine("sayı gir");
            double ss1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(KdvEkle(ss1));
            //ürüntipi gıda ise %8
            //eğitim ise %5, diğer%18
            //ekleyip geri döndür.
            
            Console.WriteLine("ürün kdvsiz fiyat :");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ürün tipi : ");
            string uruntip = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(KdvDahilHesap(fiyat,uruntip));


        }//main son
        static void MerhabaDunya(string isim)// void hiçbirşey döndürmez
        {

            Console.WriteLine("merhaba "+isim);
        }
        static int topla(int s1, int s2)
        {
            Console.WriteLine("s1+s2 toplamı=");
            int toplam = s1 + s2;
            return toplam;
            
        }
        static int buyukolani(int s1,int s2)
        {
            Console.WriteLine("buyuk olan");
            if (s1 > s2)
                return s1;
            else
                return s2;
        }
        static int Karesi(int s)
        {
            Console.WriteLine("4 karesini bulacaksın"); 
            return s * s; }

        static int BuyukOlaniDondur(int s1, int s2, int s3)
        {
            Console.WriteLine("Merhaba Dünya");
            int buyuk = s1;
            if (s2 > buyuk)
                buyuk = s2;
            if (s3 > buyuk)
                buyuk = s3;
            return buyuk;
        }
        static double KdvEkle(double s1)
        {
            Console.WriteLine("kdv li fiyatı");
            double top = s1+(s1 * 0.18);//s*1.18;
            return top;
        }
        //over loading
        static double KdvDahilHesap(double kdvsizfiyat,string uruntipi)
        {
            if (uruntipi == "gıda")
                return kdvsizfiyat * 1.08;
            else if (uruntipi == "eğitim")
                return kdvsizfiyat * 1.05;
            else
                return kdvsizfiyat * 1.18;
        }

    }
}
//f12 methodun üstüne geldiğinde buraya basarsan, seni metodun olduğu bölgeye götür.