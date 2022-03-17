using System;

namespace ConsoleApp6
{
    interface IKirilabilen { 
    
    }
    interface IBozulabilen { 
    
    }
    interface ITarihiGelmis { 
    
    }
    abstract class Gida {
        public Gida()
        {

        }
    }
    abstract class Urun {

        public Urun()
        {

        }
    }
    
    class Bardak:Urun,IKirilabilen {}
    class Sut:Gida,IBozulabilen,ITarihiGelmis{
        
    }
    class Yogurt:Gida,IBozulabilen,ITarihiGelmis { }
    class KagitHavlu:Urun { }
    class Yumurta:Gida,IKirilabilen,IBozulabilen{ }
    class Program
    {
        static void Main(string[] args)
        {
            // Soru: 
            // Bir market urun olarak Bardak, Sut, Yogurt, KagitHavlu, Yumurta gibi urunler satmaktadır.DASD
            // Bu ürünlerden bazıları kırılabilen, bazısı bozulabilen veya belirli bir sürede satılması
            // gereken urunlerdir.
            // 1- Marketteki bütün ürünleri Listele
            // 2- Ürün ekleyebildiğimiz
            // 3- Çeşitli durumlara göre rapor alabildiğimiz(Süresi geçmiş ürünler, kırık urunler vb.)

            //Yukarıdaki durumları göz önune alarak gerekli sistemi OOP kullanarak modelleyiniz.

            Sut sut1 = new Sut();
            Bardak bardak1 = new Bardak();
            Yogurt yogurt1 = new Yogurt();
            KagitHavlu kH1 = new KagitHavlu();
            Yumurta yum1 = new Yumurta();



        }
    }
}
