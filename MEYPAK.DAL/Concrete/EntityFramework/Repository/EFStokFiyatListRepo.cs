using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokFiyatListRepo : EFBaseRepo<MPSTOKFIYATLIST>, IStokFiyatListDal
    {
        MEYPAKContext context;
        public EFStokFiyatListRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }
        public MPSTOKFIYATLIST EkleyadaGuncelle(MPSTOKFIYATLIST entity)
        {
            bool exists = context.MPSTOKFIYATLIST.Any(x => x.ID == entity.ID);
            if (!exists)
            {
                context.MPSTOKFIYATLIST.Add(entity);
                context.SaveChanges();
                return entity;
            }
            else
            {
                MPSTOKFIYATLIST temp = context.MPSTOKFIYATLIST.Where(x => x.ID == entity.ID).FirstOrDefault();
                context.ChangeTracker.Clear();
                context.MPSTOKFIYATLIST.Update(entity);
                context.SaveChanges();
                return entity;
            }
        }
    }
}
