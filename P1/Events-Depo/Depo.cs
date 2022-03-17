using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Depo
{
    class Depo
    {
        List<Urun> _depo;
        public Depo(int kapasite)
        {
            _depo = new List<Urun>(kapasite);
        }
        public event EventHandler DepoBos;
        public event EventHandler DepoDolu;

        public void Ekle(Urun urun)
        {
            if (_depo.Count < 10)
                _depo.Add(urun);
            else if (DepoDolu != null)
                DepoDolu(this,new EventArgs());

        }
    }
}
