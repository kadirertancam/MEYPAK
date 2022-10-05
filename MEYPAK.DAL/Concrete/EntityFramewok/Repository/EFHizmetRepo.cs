using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Concrete.EntityFramewok.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System.Linq.Expressions;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFHizmetRepo :EFBaseRepo<MPHIZMET> ,IHizmetDal
    {
        MEYPAKContext context;

        public EFHizmetRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }


        public Durum EkleyadaGuncelle(MPHIZMET entity)
        {
            bool exists = context.MPHIZMET.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPHIZMET.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPHIZMET temp = context.MPHIZMET.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPHIZMET.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }

      
    }
}
