using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Reflection;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokOlcuBrRepo : EFBaseRepo<MPSTOKOLCUBR>, IStokOlcuBrDal
    {
        MEYPAKContext _context;

        public EFStokOlcuBrRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
            
        }

        public List<MPSTOKOLCUBR> PagingList(int skip, int take)
        {
            return _context.MPSTOKOLCUBR.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }

    

    }
}
