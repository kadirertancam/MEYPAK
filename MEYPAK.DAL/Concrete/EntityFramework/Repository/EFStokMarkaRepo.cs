using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using System.Linq.Expressions;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokMarkaRepo : EFBaseRepo<MPSTOKMARKA>, IStokMarkaDal
    {
        MEYPAKContext context;

        public EFStokMarkaRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }



        public Durum EkleyadaGuncelle(MPSTOKMARKA entity)
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
                MPSTOKMARKA temp = context.MPMARKA.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPMARKA.Update(entity);
                context.SaveChanges();
                return Durum.güncellemebaşarılı;
            }
        }


    }
}
