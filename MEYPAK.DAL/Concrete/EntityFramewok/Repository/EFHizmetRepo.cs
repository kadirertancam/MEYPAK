using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System.Linq.Expressions;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFHizmetRepo : IHizmetDal
    {
        MEYPAKContext context = new MEYPAKContext();
        public Interfaces.Durum Ekle(MPHIZMET entity)
        {
            context.MPHIZMET.Add(entity);
            return Interfaces.Durum.başarılı;
        }

        public Durum EkleyadaGuncelle(MPHIZMET entity)
        {
            throw new NotImplementedException();
        }

        public List<MPHIZMET> Getir(string entity)
        {
            return context.MPHIZMET.Where(x => x.ID.ToString() == entity).ToList();
        }

        public List<MPHIZMET> Getir(Expression<Func<MPHIZMET, bool>> predicate)
        {
            return context.MPHIZMET.Where(predicate).ToList();
        }

        public List<MPHIZMET> Guncelle(MPHIZMET entity)
        {
            context.MPHIZMET.Update(entity);
            return Getir(entity.ID.ToString());
        }

        public List<MPHIZMET> Listele()
        {
            return context.MPHIZMET.ToList();
        }

        public bool Sil(Expression<Func<MPHIZMET, bool>> predicate)
        {
            return Sil(context.MPHIZMET.Where(predicate).ToList());
        }

        public bool Sil(List<MPHIZMET> entity)
        {
            foreach (var item in entity)
            {
                context.MPHIZMET.Remove(item);
            }
            return true;
        }
    }
}
