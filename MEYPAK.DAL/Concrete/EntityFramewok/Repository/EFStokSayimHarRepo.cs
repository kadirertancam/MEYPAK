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
    public class EFStokSayimHarRepo : IStokSayimHarDal
    {
        MEYPAKContext context = new MEYPAKContext();
        public Durum Ekle(MPSTOKSAYIMHAR entity)
        {
             context.Add(entity);
            context.SaveChanges();
            return Durum.başarılı;
        }

        public Durum EkleyadaGuncelle(MPSTOKSAYIMHAR entity)
        {
            bool exists = context.MPSTOKSAYIMHAR.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPSTOKSAYIMHAR.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPSTOKSAYIMHAR temp = context.MPSTOKSAYIMHAR.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPSTOKSAYIMHAR.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }

        public List<MPSTOKSAYIMHAR> Getir(string entity)
        {
            return context.MPSTOKSAYIMHAR.Where(x => x.ID.ToString() == entity).ToList();
        }

        public List<MPSTOKSAYIMHAR> Getir(Expression<Func<MPSTOKSAYIMHAR, bool>> predicate)
        {
            return context.MPSTOKSAYIMHAR.Where(predicate).ToList();
        }

        public List<MPSTOKSAYIMHAR> Guncelle(MPSTOKSAYIMHAR entity)
        {
            context.MPSTOKSAYIMHAR.Update(entity);
            return Getir(entity.ID.ToString());
        }

        public List<MPSTOKSAYIMHAR> Listele()
        {
            return context.MPSTOKSAYIMHAR.ToList();
        }

        public bool Sil(Expression<Func<MPSTOKSAYIMHAR, bool>> predicate)
        {
            return Sil(predicate);
        }

        public bool Sil(List<MPSTOKSAYIMHAR> entity)
        {
            foreach (var item in entity)
            {
                context.Remove(item);
            }
            return true;
        }
    }
}
