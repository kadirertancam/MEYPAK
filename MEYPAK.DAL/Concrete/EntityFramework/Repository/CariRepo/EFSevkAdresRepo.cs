using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.CARI;
using System.Reflection;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.CariRepo
{
    public class EFSevkAdresRepo : EFBaseRepo<MPSEVKADRES>, ISevkAdresDal
    {
        MEYPAKContext _context;
        public EFSevkAdresRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

  
    }
}
