using System;
using System.Collections;

namespace ConsoleApp2
{
    public enum Siralama { IDyeGore=1,AdaGore=2,FiyataGore=3}
    class Karsilastir : IComparer
    {
        public Siralama Sirala { get; set; }

        public int Compare(object x, object y)
        {
            Urun u1 = (Urun)x;
            Urun u2 = (Urun)y;
            
            if(Sirala==Siralama.IDyeGore)
            {
                return u1.UrunID.CompareTo(u2.UrunID);
            }
            else if(Sirala==Siralama.AdaGore)
            {
                return u1.UrunAdi.CompareTo(u2.UrunAdi);
            }
            else //if(Sirala==Siralama.FiyataGore)
            {
                return u1.Fiyat.CompareTo(u2.Fiyat);
            }

        }
    }
    class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }


        public override string ToString()
        {
            return UrunID + " " + UrunAdi + " " + Fiyat;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList list3 = new ArrayList() {
            new Urun { UrunID = 24, UrunAdi = "Kalem", Fiyat = 20 },
            new Urun { UrunID = 25, UrunAdi = "Defter", Fiyat = 80  },
            new Urun { UrunID = 12, UrunAdi = "Silgi", Fiyat = 10 } 
            };
            Karsilastir karsilastir = new Karsilastir();
            karsilastir.Sirala = Siralama.IDyeGore;
            list3.Sort(karsilastir);
            foreach (Urun item in list3)
            {
                //Console.WriteLine(item.UrunID+" "+item.UrunAdi);
                Console.WriteLine(item);
            }





        }
    }
}
