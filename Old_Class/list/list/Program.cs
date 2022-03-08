using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            // list dizilerden farklı olarak: kapasitesi sınırlı değildir.
            //otomatik genişler.
            /*
                        //tanımlama
                        List<int> ilklistem = new List<int>();
                        List<string> sehirler = new List<string>() { "istanbul", "ankara", "adana", "izmir", "van" };

                        //string[] sehirler2 = new string[] { "istanbul", "ankara", "adana", "izmir", "van" };//array de yapmak istesek
                        List<int> araliste = new List<int>() { 1000, 2000, 3000 };
                        //veri ekleme
                        ilklistem.Add(1990);//add metodu listenin sonuna ekler.insert araya sıkıştırır.
                        ilklistem.Add(1231);
                        ilklistem.Insert(0, 1988);//0.index e 1988 iatar.
                       // Console.WriteLine("listedeki elemanların sayısı: " + ilklistem.Count());//asıl liste çıkar
                        ilklistem.InsertRange(2, araliste);//2.sıraya aralisteyi koyar.
                        ilklistem.AddRange(ilklistem);
                        //Console.WriteLine("listedeki elemanların sayısı: " + ilklistem.Count()); //eklenen araliste ile toplamı çıkar.
                        foreach (var item in ilklistem)
                        { Console.WriteLine(item); }

                        Console.WriteLine("1231 in indexi " + ilklistem.IndexOf(1231));



                        sehirler.Add("hakkari");
                        //Console.WriteLine("2.indisteki şehir : "+sehirler[2]); // İstanbulu saydığından 2.indis te adana var
                        sehirler.Remove("istanbul");
                        Console.WriteLine("2.indisteki şehir : " + sehirler[2]); // İstanbulu sildiğimizden 2.indis te izmir var
                        sehirler.Insert(3, "urfa");
                        sehirler.RemoveAt(1);

                        foreach (var item in sehirler)
                        {
                            Console.WriteLine(item);
                        }

                        //listede varmı? 
                        bool sivascheck = sehirler.Contains("sivas");
                        if(sivascheck)
                            Console.WriteLine("sivas listede var.");
                        else
                            Console.WriteLine("sivas listede yok");

               */
            
            List<string> liste = new List<string>();
            liste.Add("Ahmet");
            liste.Add("Ayşe");
            liste.Add("Selvi");
            liste.Add("Müslüm");
            liste.Add("Betül");
            liste.Add("Okan");
            liste.Add("Hayri");
            // List yapılarında boyut sınırlı değil. 
            /*
            Console.WriteLine(liste[0]);
            Console.WriteLine(liste[1]);

            int v = liste.Count;
            Console.WriteLine("Listedeki eleman sayısı:" + v);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------");
            liste.Remove("Hayri");
            liste.RemoveAt(0);

            //liste.Remove("Selvi");
            int indis = -1;
            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i].ToUpper() == "selvi".ToUpper())
                {
                    indis = i;
                    break;
                }
            }
            if (indis != -1)
                liste.RemoveAt(indis);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            */
           //program p =new program();
            if(ElemanListedeVarMi(liste,"mehmet"))
            { Console.WriteLine("mehmet var.");}
            else
                Console.WriteLine("listede mehmet yok.");
            Console.ReadLine();
            }
        public static bool ElemanListedeVarMi(List<string> isimler, string arananIsım)
        {
            foreach (var isim in isimler)
            {
                if (isim == arananIsım)
                    return true;
            }
            return false;
        }









    }
}
