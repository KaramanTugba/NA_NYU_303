using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class Market<T> where T:Urun
    {
        List<T> urunler = new List<T>();
        public void UrunEkle(T t)
        {
            urunler.Add(t);
        }
        //Ortam bağımsız yapı oluşturmak için 17.line kullanılır.
        public List<T> TumUrunler()
        {
            return urunler;
        }

        //KIRIK 
        
        public List<IKirilabilir> KirikUrunler()
        {
            
            List <IKirilabilir> _urunler = new List<IKirilabilir>();
            foreach (var item in urunler)
            {
                if (item is IKirilabilir)
                    if (((IKirilabilir)item).Kirik)
                        _urunler.Add((IKirilabilir)item);
                    
            }
            return _urunler;
        }

        public List<IBozulabilir> BozukUrunler()
        {
            
            List<IBozulabilir> _urunler = new List<IBozulabilir>();
            foreach (Urun item in urunler)
            {
                var urun = item as IBozulabilir;
                if (urun!=null&&urun.SKT<DateTime.Now)
                    _urunler.Add(urun);
            }
            return _urunler;
        }


    }
}
