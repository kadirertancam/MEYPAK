using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramewok.Repository
{
    public class EFOlcuBrRepo : IOlcuBrDal
    {
        string hata;
        MEYPAKContext context = new MEYPAKContext();
        public Durum Ekle(MPOLCUBR entity)
        {
               context.MPOLCUBR.Add(entity);
                context.SaveChanges();
                return Interfaces.Durum.başarılı;
            
        }

        public Durum EkleyadaGuncelle(MPOLCUBR entity)
        {
            bool exists = context.MPOLCUBR.Any(x => x.ID == entity.ID); 
            
            if (!exists)
            {
                context.MPOLCUBR.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPOLCUBR temp = context.MPOLCUBR.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPOLCUBR.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
            
        }

        public List<MPOLCUBR> Getir(string entity)
        {
            var a = context.MPOLCUBR.Where(x => x.ID.ToString() == entity).ToList();
            return a;
        }

        public List<MPOLCUBR> Getir(Expression<Func<MPOLCUBR, bool>> predicate)
        {
            return context.MPOLCUBR.Where(predicate).ToList();
        }

        public List<MPOLCUBR> Guncelle(MPOLCUBR entity)
        { 
            context.MPOLCUBR.Update(entity);
            return Getir(entity.ID.ToString());
        }

        public List<MPOLCUBR> Listele()
        {
            return context.MPOLCUBR.ToList();
        }

        public bool Sil(Expression<Func<MPOLCUBR, bool>> predicate)
        {
            return Sil(context.MPOLCUBR.Where(predicate).ToList());
        }

        public bool Sil(List<MPOLCUBR> entity)
        {
           
                foreach (var e in entity)
                {
                    context.MPOLCUBR.Remove(e);
                    context.SaveChanges();
                }
                return true;
           

        }
    }
}
