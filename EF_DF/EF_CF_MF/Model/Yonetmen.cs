using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF_MF.Model
{
   public class Yonetmen
    {
        public int YonetmenID { get; set; }
        public string YonetmenAD { get; set; }
        
        public ICollection<Film> Filmler { get; set; }
    }
}
