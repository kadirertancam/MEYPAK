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
    public class EFStokSayimRepo:IStokSayimDal
    {
        MEYPAKContext context = new MEYPAKContext();
        public Durum Ekle(MPSTOKSAYIM entity)
        {
            context.Add(entity);
            context.SaveChanges();
            return Durum.başarılı;
        }

        public Durum EkleyadaGuncelle(MPSTOKSAYIM entity)
        {

            bool exists = context.MPSTOKSAYIM.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPSTOKSAYIM.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPSTOKSAYIM temp = context.MPSTOKSAYIM.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPSTOKSAYIM.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }

        public List<MPSTOKSAYIM> Getir(string entity)
        {
            return context.MPSTOKSAYIM.Where(x => x.ID.ToString() == entity).ToList();
        }

        public List<MPSTOKSAYIM> Getir(Expression<Func<MPSTOKSAYIM, bool>> predicate)
        {
            return context.MPSTOKSAYIM.Where(predicate).ToList();
        }

        public List<MPSTOKSAYIM> Guncelle(MPSTOKSAYIM entity)
        {
            context.MPSTOKSAYIM.Update(entity);
            return Getir(entity.ID.ToString());
        }

        public List<MPSTOKSAYIM> Listele()
        {
            return context.MPSTOKSAYIM.ToList();
        }

        public bool Sil(Expression<Func<MPSTOKSAYIM, bool>> predicate)
        {
            return Sil(predicate);
        }

        public bool Sil(List<MPSTOKSAYIM> entity)
        {
            foreach (var item in entity)
            {
                context.Remove(item);
            }
            return true;
        }
    }
}
