using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System;
using System.Data.Entity;
using System.Linq.Expressions;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
 
    public class EFStokRepo : IStokDal
    {
        
        MEYPAKContext context = new MEYPAKContext();
        string hata;
        public Interfaces.Durum Ekle(MPSTOK entity)
        { 
            context.MPSTOK.Add(entity);
                context.SaveChanges();
                return Interfaces.Durum.başarılı;
            

           
        }

        public Durum EkleyadaGuncelle(MPSTOK entity)
        { 
            bool exists = context.MPSTOK.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPSTOK.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPSTOK temp = context.MPSTOK.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPSTOK.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }

        public List<MPSTOK> Getir(string entity)
        {
            onYukle();
            return context.MPSTOK.Where(x => x.ID.ToString() == entity).ToList();
            
        }
        void onYukle()
        {
             
                var emp = context.MPSTOK.ToList();
                foreach (var item in emp)
                {
                context.Entry(item)
                    .Collection(e => e.MPSTOKOLCUBR)
                    .Load();
                } 
            
        }
        public List<MPSTOK> Getir(Expression<Func<MPSTOK, bool>> predicate)
        {
            onYukle();
            return context.MPSTOK.Where(predicate).ToList();

        }
         

        public List<MPSTOK> Guncelle(MPSTOK entity)
        { 
            context.MPSTOK.Update(entity);
            return Getir(entity.ID.ToString());
        }

        public List<MPSTOK> Listele()
        {
            onYukle();
            return context.MPSTOK.ToList();
            
             
            
        }

        public bool Sil(Expression<Func<MPSTOK, bool>> predicate)
        { 
            return Sil(context.MPSTOK.Where(predicate).ToList());

        }

        public bool Sil(List<MPSTOK> entity)
        { 
            foreach (var item in entity)
            {
                context.MPSTOK.Remove(item);
                context.SaveChanges();
            }
            return true;
        }

        
    }
}
