using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Ders10_WindowsForms_OOP
{
    class araba
    {
        public int ID;
        public string Marka;
        public string Model;
        /*YAPICI METOTLAR: CONSTRUCTOR
* Metot adı sınıf adı ile aynı olmalıdır. Public olmalıdır.
* Tanımlanmasa da boş hali arka planda çalışır.
*/
        public araba()
{
            //MessageBox.Show("Yapıcı method çalıştı.");

}
        public araba(int ID, string marka, string model)
        {
            MessageBox.Show("3parametreli yapıcı metot çalıştı.");
            this.ID = ID;
            Marka = marka;
            Model = model;
        }
        public void BilgiYaz()
        {
            MessageBox.Show("ID:"+this.ID);
            MessageBox.Show("Marka:"+ this.Marka);
            MessageBox.Show("Model:" +this.Model);
      
        }


    }
}
