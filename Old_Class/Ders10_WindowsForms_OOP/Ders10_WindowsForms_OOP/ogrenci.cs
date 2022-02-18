using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Ders10_WindowsForms_OOP
{/*
  * ogrenci sınıfı aşağıdaki özellik ve methodları tanımlayınız.
  * properties: tckimlikno,okulno,ad,soyad,sinifogretmeni
  * methods: sinifogretmenidegistir(string ogretmen)
  * methods: bilgiyaz() ogrencinin bütün bilgilerini yazdırsın
  * methods: parametreli yapıcı method ekleyin
  * */
    /* Access Modifiers; Erişim Belirleyici
     * 1-Private: Özel anlamındadır. Sadece bulunduğu yapı
     * içinden erişilebilir. Başka yerden erişilemez.
     * 2-Internal: Bulunduğu proje içinde her yerden 
     * erişimi sağlar. Farklı projeden reişime izin vermez.
     * 3-Protected: Miras alınan sınıflar içerisinden 
     * erişime izin verir. 
     * 4-Protected Internal: Hem Miras alınan sınıflar 
     * içerisinden hem de bulunduğu proje içinde her yerden 
     * erişime izin verir. 
     * 5-Public: Umumi, kamu malıdır. Her yerden erişime
     * izin verir.*/
    

    class ogrenci
    {
    public int Tckimlikno;
    public int Okulno;
    public string Ad;
    public string Soyad;
    public Ogretmen Sinifogretmeni;

        public ogrenci(int tckimlikno, int okulno, string ad, string soyad, Ogretmen sinifogretmeni)
        {
            Tckimlikno = tckimlikno;
            Okulno = okulno;
            Ad = ad;
            Soyad = soyad;
            Sinifogretmeni = sinifogretmeni;
        }
        public void BilgiYaz(ListBox listBox1)
        {
            MessageBox.Show("TC:" + this.Tckimlikno+" "+ "OkulNo:" + this.Okulno + " "+ "Ad:" + this.Ad + " "+ "Soyad:" + this.Soyad + " "+"SinifOgretmeni:"+this.Sinifogretmeni.Ad+" "+Sinifogretmeni.Soyad);
            listBox1.Items.Add("TC:" +Tckimlikno + " " + "OkulNo:" + Okulno + " " + "Ad:" +Ad + " " + "Soyad:" + Soyad + " " + "SinifOgretmeni:" + Sinifogretmeni.Ad+" "+Sinifogretmeni.Soyad);
        }
        public void Ogretmendegistir(Ogretmen ogretmen)
        {
            Sinifogretmeni = ogretmen;
            MessageBox.Show("öğretmen değişti");

        }
    }
}
