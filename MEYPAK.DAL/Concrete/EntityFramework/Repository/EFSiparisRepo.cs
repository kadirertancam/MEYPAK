using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFSiparisRepo : EFBaseRepo<MPSIPARIS>, ISiparisDal
    {
        MEYPAKContext context;
        public EFSiparisRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
          
        }

        public List<MPSIPARIS> PagingList(int skip, int take)
        {
            return context.MPSIPARIS.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }

    
    }
}  
