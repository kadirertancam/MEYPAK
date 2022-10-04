using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramewok.Repository
{
    public class EFBaseRepo<T> : IGeneric<T> where T : class,new()
    {
        private readonly MEYPAKContext context;
        public EFBaseRepo(MEYPAKContext _context)
        {
            this.context = _context;
        }
        public Interfaces.Durum Ekle(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return Interfaces.Durum.başarılı;



        }

        //public Durum EkleyadaGuncelle(T entity)
        //{
        //    bool exists = context.Set<T>().Any(x => x.GetType().GetProperty("ID").GetValue() == entity.ID);
        //    if (!exists)
        //    {
        //        context.Set<T>().Add(entity);
        //        context.SaveChanges();
        //        return Durum.kayıtbaşarılı;
        //    }
        //    else
        //    {
        //        T temp = context.Set<T>().Where(x => x.ID == entity.ID).FirstOrDefault();
        //        context.ChangeTracker.Clear();
        //        context.Set<T>().Update(entity);
        //        context.SaveChanges();
        //        return Durum.güncellemebaşarılı;
        //    }
        //}

        public List<T> Getir(string entity)
        {
            
            return context.Set<T>().Where(x => x.GetType().GetProperty("ID").GetValue(x).ToString() == entity).ToList();

        }
        //void onYukle()
        //{

        //    var emp = context.Set<T>().ToList();
        //    foreach (var item in emp)
        //    {
        //        context.Entry(item)
        //            .Collection(e => e.TOLCUBR)
        //            .Load();
        //    }

        //}
        public List<T> Getir(Expression<Func<T, bool>> predicate)
        {
            
            return context.Set<T>().Where(predicate).ToList();

        }


        public List<T> Guncelle(T entity)
        {
            context.Set<T>().Update(entity);
            return Getir(entity.GetType().GetProperty("ID").GetValue(entity).ToString().ToString());
        }

        public List<T> Listele()
        {
          
            return context.Set<T>().ToList();



        }

        public bool Sil(Expression<Func<T, bool>> predicate)
        {
            return Sil(context.Set<T>().Where(predicate).ToList());

        }

        public bool Sil(List<T> entity)
        {
            foreach (var item in entity)
            {
                context.Set<T>().Remove(item);
                context.SaveChanges();
            }
            return true;
        }
    }
}
