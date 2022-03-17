using System;

namespace Events
{
    //1-Temsilciye ihtiyaç var
    //2-O temsilci tipinden event tanımlanır.
    //3- Olayı tetikleyecek mekanizma kurulur.
    //4-Class oluşturulur
    //5-Olaya bir method bağlanır.
    //9-Çalıştır
    
    delegate void Temsilci();
    class Buton {
        
        public event Temsilci Tikla;

        public void Calistir()
        {
            if (Tikla != null)
                Tikla();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Events

            Buton btn = new Buton();
            btn.Tikla +=new Temsilci(Btn_Tikla);
            btn.Calistir();
        }

        private static void Btn_Tikla()
        {
            Console.WriteLine("butona tıklandı.");
        }
    }
}
