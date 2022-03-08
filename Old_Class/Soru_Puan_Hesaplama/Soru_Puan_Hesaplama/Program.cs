using System;

namespace Soru_Puan_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int puan=0;
            Console.WriteLine("1.soru: Türkiye’de Erozyonla mücadele amacıyla kurulan vakfın kısa adı nedir? (5 puan)");
            string soru1 = Console.ReadLine();
            string cevap1 = "tema";
            Console.WriteLine("2.soru: Gece gündüz eşitliği (ekinoks) bir yılda kaç kez gerçekleşir? (10 puan)");
            string soru2 = Console.ReadLine();
            string cevap2 = "2";
            Console.WriteLine("3.soru: UEFA Kupasını alan ilk Türk takımı hangisidir? (2 puan)");
            string soru3 = Console.ReadLine();
            string cevap3 = "galatasaray";
            Console.WriteLine("4.soru: Müzik ezgileri yazılırken sesleri gösteren işaretlere ne ad verilir ? (5 puan)");
            string soru4 = Console.ReadLine();
            string cevap4 = "nota";
            Console.WriteLine("5.soru: Pisagor teoremi hangi bilim dalıyla ilgilidir ? (8 puan)");
            string soru5 = Console.ReadLine();
            string cevap5 = "matematik";
            if (soru1 == cevap1)
                puan += 5;
            if (soru2 == cevap2)
                puan += 10;
            if (soru3 == cevap3)
                puan += 2;
            if (soru4 == cevap4)
                puan += 5;
            if (soru5 == cevap5)
                puan += 8;
                       
            
            Console.WriteLine("\n\nAldığınız puan "+puan+" dır.");










            Console.Read();

        }
    }
}
