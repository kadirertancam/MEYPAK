
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Interfaces;
using System.Linq.Expressions;
using System.Reflection;


namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFBaseRepo<T> : IGeneric<T> where T : class, new()
    {
        private readonly MEYPAKContext context;
        private List<T> tList = new List<T>();
        public EFBaseRepo(MEYPAKContext _context)
        {
            context = _context;

        }
        public T Ekle(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return entity;
        }

        public List<T> Getir(Expression<Func<T, bool>> filter)
        {
            return context.Set<T>().Where(filter).ToList();

        }
        public List<T> Getir(int id)
        {
            if (tList != null) tList.Clear();
            tList.Add(context.Set<T>().Find(id));
            return tList;

        }

     

        public Durum Guncelle(T entity, Expression<Func<T, bool>> predicate)
        {
            if (entity.GetType().GetProperties().Any(x => x.Name == "ID"))
            {
                T item = Getir(predicate).FirstOrDefault();
                PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                propertyInfo.SetValue(item, Convert.ChangeType(1, propertyInfo.PropertyType), null);
                context.Set<T>().Update(item);

                propertyInfo = (entity.GetType().GetProperty("ID"));
                propertyInfo.SetValue(entity, Convert.ChangeType(0, propertyInfo.PropertyType), null);
                context.Set<T>().Add(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
            else
            {
                return Durum.başarısız;
            }
        }
        public Durum Guncelle(T entity)
        {
            context.Update(entity);
            return Durum.güncellemebaşarılı;
        }

        public List<T> Listele()
        {
            //IQueryable<T> query = context.Set<T>(); // select * from MPSTOK
            //if (filter != null)
            //{
            //    query = query.Where(filter); // select * from MPSTOK where FİLTER
            //}
            //if (includeEntities != null) //innerjoin
            //{
            //    foreach (var item in includeEntities.Split(","))
            //    {
            //        query = query.Include();
            //    }
            //}
            //return query.ToList();
        
            var A = context.Set<T>().ToList();
            return A;
        }

        public bool DeleteById(int id)
        {
            return Sil(Getir(id)); 
        }

        public bool Sil(List<T> entity)
        {
            foreach (T item in entity)
            {
                if (item.GetType().GetProperties().Any(x => x.Name == "KAYITTIPI"))
                {
                    context.ChangeTracker.Clear();
                    PropertyInfo propertyInfo = (item.GetType().GetProperty("KAYITTIPI"));
                    propertyInfo.SetValue(item, Convert.ChangeType(2, propertyInfo.PropertyType), null);
                    context.Set<T>().Update(item);
                    context.SaveChanges();
                }

            }
            return true;
        }

        T IGeneric<T>.Guncelle(T entity)
        {
            context.Update(entity);
            return entity;
        }

        List<T> IGeneric<T>.Listele()
        {
            return context.Set<T>().ToList();
        }

  


        //public Durum EkleyadaGuncelle(T entity)
        //{
        //    bool exists = context.Set<T>().Any(x => x.GetType().GetProperty("ID").GetValue(x).ToString() == entity.GetType().GetProperty("ID").GetValue(entity).ToString());
        //    if (!exists)
        //    {
        //        context.Set<T>().Add(entity);
        //        context.SaveChanges();
        //        return Durum.kayıtbaşarılı;
        //    }
        //    else
        //    {
        //        T temp = context.Set<T>().Where(x => x.GetType().GetProperty("ID").GetValue(x) == entity.GetType().GetProperty("ID").GetValue(entity)).FirstOrDefault();
        //        context.ChangeTracker.Clear();
        //        context.Set<T>().Update(entity);
        //        context.SaveChanges();
        //        return Durum.güncellemebaşarılı;
        //    }
        //}
    }
}
