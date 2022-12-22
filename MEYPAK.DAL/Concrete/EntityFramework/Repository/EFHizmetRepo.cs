using MEYPAK.DAL.Abstract.HizmetDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using System.Linq.Expressions;
using System.Reflection;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFHizmetRepo : EFBaseRepo<MPHIZMET>, IHizmetDal
    {
        MEYPAKContext context;

        public EFHizmetRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }

        public List<MPHIZMET> PagingList(int skip, int take)
        {
            return context.MPHIZMET.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }


    


    }
}
