using System;
using System.Threading;

namespace Events2
{
    delegate void Temsilci();
    class Isitici
    {
        public int ISI { get; set; }
        public event Temsilci Kabarciklanma;
        public event Temsilci SesCikar;
        public event Temsilci Fokurdama;
        public void Calistir()
        {
            for (int i = 0; i < 120; i++)
            {
                Thread.Sleep(50);
                ISI++;
                Console.WriteLine(ISI);
                //mekanizmayyı kuruyorum
                if (ISI >= 30 && ISI < 50 && Kabarciklanma != null) //30 50 arası eventi tetikle
                {
                    Kabarciklanma();//delege metot baglıysa calıstır metot yoksa hata verir
                }

                else if (ISI >= 50 && ISI < 80 && SesCikar != null) // 50 80 arası eventi tetikle
                {
                    SesCikar();//delege metot baglıysa calıstır metot yoksa hata verir
                }
                else if (ISI >= 80 && ISI < 110 && Fokurdama != null) //80 100 arası eventi tetikle
                {
                    Fokurdama();//delege metot baglıysa calıstır metot yoksa hata verir
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Isitici ısıtıcı = new Isitici();



            ısıtıcı.Kabarciklanma += Isıtıcı_Kabarciklanma;
            ısıtıcı.SesCikar += Isıtıcı_SesCıkar;
            ısıtıcı.Fokurdama += Isıtıcı_Fokurdama;
            ısıtıcı.Calistir();
        }

        private static void Isıtıcı_Fokurdama()
        {
            Console.WriteLine("FOKUR FOKUR");
        }

        private static void Isıtıcı_SesCıkar()
        {
            Console.WriteLine("SSSSSSSSSSS");
        }

        private static void Isıtıcı_Kabarciklanma()
        {
            Console.WriteLine("o O o O o O o O o O o O o O o O o O o O o O o O ");
        }
    }
}
