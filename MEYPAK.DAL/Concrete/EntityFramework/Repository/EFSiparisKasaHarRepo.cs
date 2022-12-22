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
    public class EFSiparisKasaHarRepo : EFBaseRepo<MPSIPARISKASAHAR>, ISiparisKasaHarDal
    {
        MEYPAKContext context;
        public EFSiparisKasaHarRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }

       
    }
}
