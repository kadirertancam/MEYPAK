using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.Models.DEPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFCariKartRepo : EFBaseRepo<MPCARIKART>, ICariKartDal
    {
        MEYPAKContext context;
        public EFCariKartRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }


        public List<MPCARIKART> PagingList(int skip, int take)
        {
            return context.MPCARIKART.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }

   
    }
}
