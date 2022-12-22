using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.SIPARIS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFSatınAlmaMalKabulEmriHarRepo : EFBaseRepo<MPSATINALMAMALKABULEMRIHAR>,ISatinAlmaMalKabulEmriHarDal
    {
        MEYPAKContext context;
        public EFSatınAlmaMalKabulEmriHarRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }

        public List<MPSATINALMAMALKABULEMRIHAR> PagingList(int skip, int take)
        {
            return context.MPSATINALMAMALKABULEMRIHAR.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }

      
    }
}
