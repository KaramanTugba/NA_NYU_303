using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF_MF.Model
{
    public class Kategori
    {
        public int KategoriID { get; set; }
        public string KategoriAD { get; set; }
        //navigation
        public  virtual ICollection<Film> Filmler { get; set; }
        
    }
}
