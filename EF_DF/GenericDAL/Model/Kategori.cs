using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDAL.Model
{
    public class Kategori:IEntity
    {
        public int KategoriID { get; set; }
        public string KategoriAD { get; set; }
        //navigation
        public  virtual ICollection<Film> Filmler { get; set; }
        
    }
}
