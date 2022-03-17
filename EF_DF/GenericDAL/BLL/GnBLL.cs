using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericDAL.Model;
using GenericDAL.DAL;

namespace GenericDAL.BLL
{
    public class GnBLL<T> where T:class,IEntity
    {
        GnFilmDB db;
        //Dependency Injection olmalı...
        public GnBLL(GnFilmDB _db)
        {
            db = _db;

        }
        public void Ekle(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }
        
        public List<T> Liste()
        {
            return db.Set<T>().ToList();
        }

    }
}
