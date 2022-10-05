using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Concrete.EntityFramewok.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System.Linq.Expressions;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFMarkaRepo : EFBaseRepo<MPMARKA>,IMarkaDal
    {
        MEYPAKContext context;

        public EFMarkaRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }



        public Durum EkleyadaGuncelle(MPMARKA entity)
        {
            bool exists = context.MPMARKA.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPMARKA.Add(entity);
                context.SaveChanges();
                return Durum.kayıtbaşarılı;
            }
            else
            {
                MPMARKA temp = context.MPMARKA.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPMARKA.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }

       
    }
}
