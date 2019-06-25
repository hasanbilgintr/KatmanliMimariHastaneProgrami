using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Hastane.DLL;

namespace Hastane.BLL
{
    public class Repository<T> where T : class
    {
        HastahaneDBEntities db = new HastahaneDBEntities();

        public List<T> Listele()
        {
            return db.Set<T>().ToList();
        }

        public int Ekle(T nesnetablo)
        {
            db.Set<T>().Add(nesnetablo);
            return db.SaveChanges();
        }

        public int Guncelle(T nesnetablo)
        {
            return db.SaveChanges();
        }

        public int Sil(T nesnetablo)
        {
            db.Set<T>().Remove(nesnetablo);
            return db.SaveChanges();
        }

        public IQueryable<T> Filtrele(Expression<Func<T, bool>> sorgu)
        {
            //Ling ile Filtreleme yapmak için IQueryale yapabiliriz
            //Expression<Func<T, bool>> sorgu==> bir parametre olarak tanımladık.
            return db.Set<T>().Where(sorgu);
        }

        public T Bul(Expression<Func<T, bool>> sorgu)
        {
            //return db.Set<T>().Where(sorgu).FirstOrDefault();
            return db.Set<T>().FirstOrDefault(sorgu);
        }

        public List<T> Liste(Expression<Func<T, bool>> sorgu)
        {
            return db.Set<T>().Where(sorgu).ToList();
        }

        

    }
}


