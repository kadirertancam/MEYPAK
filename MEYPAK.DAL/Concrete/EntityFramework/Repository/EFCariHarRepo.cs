using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFCariHarRepo : EFBaseRepo<MPCARIHAR>, ICariHarDal
    {
        MEYPAKContext context;
        public EFCariHarRepo(MEYPAKContext _context) : base(_context)
        {
            this.context = _context;
        }
     
    }
}
