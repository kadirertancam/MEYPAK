using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFDepoRepo : IDepoDal
    {
        MEYPAKContext context = new MEYPAKContext();
        string hata;
        public Interfaces.Durum Ekle(MPDEPO entity)
        {
            
                context.MPDEPO.Add(entity);
                context.SaveChanges();
                return Interfaces.Durum.başarılı;
           
             
               
        }

        public Durum EkleyadaGuncelle(MPDEPO entity)
        {
            bool exists = context.MPDEPO.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPDEPO.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPDEPO temp = context.MPDEPO.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPDEPO.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }

        public List<MPDEPO> Getir(string entity)
        {
            return context.MPDEPO.Where(x => x.ID.ToString() == entity).ToList();
        }

        public List<MPDEPO> Getir(Expression<Func<MPDEPO, bool>> predicate)
        {
            return context.MPDEPO.Where(predicate).ToList();
        }

        public List<MPDEPO> Guncelle(MPDEPO entity)
        {
             context.MPDEPO.Update(entity);
            return Getir(entity.ID.ToString());
        }

        public List<MPDEPO> Listele()
        {
            return context.MPDEPO.ToList();
        }

        public bool Sil(Expression<Func<MPDEPO, bool>> predicate)
        {
            return Sil(context.MPDEPO.Where(predicate).ToList());
        }

        public bool Sil(List<MPDEPO> entity)
        {
            foreach (var item in entity)
            {
                context.MPDEPO.Remove(item);
            }
            return true;
        }
    }
}
