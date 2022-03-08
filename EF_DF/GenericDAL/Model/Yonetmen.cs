using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDAL.Model
{
   public class Yonetmen:IEntity
    {
        public int YonetmenID { get; set; }
        public string YonetmenAD { get; set; }
        
        public ICollection<Film> Filmler { get; set; }
    }
}
