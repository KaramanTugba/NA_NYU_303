using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CF_MF.Model;
namespace EF_CF_MF.DAL
{
    public class FilmDB:DbContext
    {
        public FilmDB()
        {
            Database.SetInitializer(new InitDB());
        }
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Oyuncu> Oyuncular { get; set; }
        public DbSet<Film_Oyuncu> Film_Oyuncu { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Yonetmen> Yonetmenler { get; set; }
               
    }
}
