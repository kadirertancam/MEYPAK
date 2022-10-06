using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using System.Linq.Expressions;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokOlcuBrRepo : EFBaseRepo<MPSTOKOLCUBR>, IStokOlcuBrDal
    {
        MEYPAKContext context;

        public EFStokOlcuBrRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }


        public Durum EkleyadaGuncelle(MPSTOKOLCUBR entity)
        {
            context.MPSTOKOLCUBR.Add(entity);
            context.SaveChanges();
            return Durum.başarılı;
        }

    }
}
