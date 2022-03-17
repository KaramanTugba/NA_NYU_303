using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF_MF.Model
{
    public class Oyuncu
    {
        public int OyuncuID { get; set; }
        [Column(TypeName="varchar"), StringLength(50)]
        public string OyuncuAD { get; set; }
        public DateTime DogumYil { get; set; } = DateTime.Now;
        public string Cinsiyet { get; set; }
        //[ ForeignKey("Oyuncular) ]
        public virtual ICollection<Film_Oyuncu> Filmler { get; set; }


    }
}
