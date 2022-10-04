using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System.Linq.Expressions;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokOlcuBrRepo : IStokOlcuBrDal
    {
        MEYPAKContext context = new MEYPAKContext();
        public Interfaces.Durum Ekle(MPSTOKOLCUBR entity)
        {
            context.MPSTOKOLCUBR.Add(entity);
            context.SaveChanges();
            return Interfaces.Durum.başarılı;
        }

        public Durum EkleyadaGuncelle(MPSTOKOLCUBR entity)
        {
             context.MPSTOKOLCUBR.Add(entity);
            context.SaveChanges();
            return Interfaces.Durum.başarılı;
        }

        public List<MPSTOKOLCUBR> Getir(string entity)
        {
            return context.MPSTOKOLCUBR.Where(x => x.ID.ToString() == entity).ToList();
        }

        public List<MPSTOKOLCUBR> Getir(Expression<Func<MPSTOKOLCUBR, bool>> predicate)
        {
            return context.MPSTOKOLCUBR.Where(predicate).ToList();
        }

        public List<MPSTOKOLCUBR> Guncelle(MPSTOKOLCUBR entity)
        {
            context.MPSTOKOLCUBR.Update(entity);
            return Getir(entity.ID.ToString());
        }

        public List<MPSTOKOLCUBR> Listele()
        {
            return context.MPSTOKOLCUBR.ToList();
        }

        public bool Sil(Expression<Func<MPSTOKOLCUBR, bool>> predicate)
        {
            return Sil(context.MPSTOKOLCUBR.Where(predicate).ToList());
        }

        public bool Sil(List<MPSTOKOLCUBR> entity)
        {
            foreach (var item in entity)
            {
                context.MPSTOKOLCUBR.Remove(item);
            }
            return true;
        }
    }
}
