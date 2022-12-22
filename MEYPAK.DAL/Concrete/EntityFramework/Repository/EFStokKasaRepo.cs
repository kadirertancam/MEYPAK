using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using System.Reflection;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokKasaRepo : EFBaseRepo<MPSTOKKASA>, IStokKasaDal
    {
        MEYPAKContext _context;
        public EFStokKasaRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

        public List<MPSTOKKASA> PagingList(int skip, int take)
        {
            return _context.MPSTOKKASA.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }

       
    }
}
