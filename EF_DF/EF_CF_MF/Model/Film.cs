using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF_MF.Model
{
    [Table("Filmler")]
    public class Film
    {
        public int FilmID { get; set; }
       [Column(TypeName ="varchar")]
        [StringLength(100)]
        public string FilmAD { get; set; }
        public int KategoriID { get; set; }
        public int YonetmenID { get; set; }
        public short Sure { get; set; }

        //navigation
        public virtual Kategori Kategori {get; set; }
        public virtual Yonetmen Yonetmen { get; set; } //null gelicek.include yazılarak eklenecek.
        public virtual ICollection<Film_Oyuncu> Oyuncular { get; set; }

    }
}
