using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EF_CF_MF.Model;

namespace EF_CF_MF.DAL
{
    public class InitDB:DropCreateDatabaseAlways<FilmDB>
    {
        protected override void Seed(FilmDB context)
        {
            context.Yonetmenler.Add(new Yonetmen { YonetmenAD = "Spielberg" });
            context.Yonetmenler.Add(new Yonetmen { YonetmenAD = "Fincher" });
            context.Yonetmenler.Add(new Yonetmen { YonetmenAD = "Tarantino" });

            context.Kategoriler.Add(new Kategori { KategoriAD = "Bilim Kurgu" });
            context.Kategoriler.Add(new Kategori { KategoriAD = "Gerilim" });
            context.Kategoriler.Add(new Kategori { KategoriAD = "Komedi" });
            context.Kategoriler.Add(new Kategori { KategoriAD = "Dram" });

            context.Oyuncular.Add(new Oyuncu { OyuncuAD = "Tom Hanks", Cinsiyet = "Erkek" });
            context.Oyuncular.Add(new Oyuncu { OyuncuAD = "Brad Pitt", Cinsiyet = "Erkek" });
            context.Oyuncular.Add(new Oyuncu { OyuncuAD = "Al Pacino", Cinsiyet = "Erkek" });
            context.Oyuncular.Add(new Oyuncu { OyuncuAD = "Scarlett Johnson", Cinsiyet = "Kadın" });
            context.Oyuncular.Add(new Oyuncu { OyuncuAD = "Jenifer Lawrance", Cinsiyet = "Kadın" });
            context.Oyuncular.Add(new Oyuncu { OyuncuAD = "Elizabeth Olsen", Cinsiyet = "Kadın" });

            context.SaveChanges();

            context.Filmler.Add(new Film { FilmAD = "Forrest Gump", Sure = 120, KategoriID = 4, YonetmenID = 1 });
            context.Filmler.Add(new Film { FilmAD = "The God Father", Sure = 125, KategoriID = 4, YonetmenID = 2 });
            context.Filmler.Add(new Film { FilmAD = "Lucy", Sure = 110, KategoriID = 1, YonetmenID = 2 });

            context.SaveChanges();
            context.Film_Oyuncu.Add(new Film_Oyuncu { FilmID = 1, OyuncuID = 1, RolAD = "Forrest" });
            context.Film_Oyuncu.Add(new Film_Oyuncu { FilmID = 2, OyuncuID = 3, RolAD = "Michael" });






        }
    }
}
