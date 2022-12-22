using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using System.Linq.Expressions;
using System.Reflection;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokMarkaRepo : EFBaseRepo<MPSTOKMARKA>, IStokMarkaDal
    {
        MEYPAKContext _context;

        public EFStokMarkaRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

        public List<MPSTOKMARKA> PagingList(int skip, int take)
        {
            return _context.MPSTOKMARKA.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }

       


    }
}
