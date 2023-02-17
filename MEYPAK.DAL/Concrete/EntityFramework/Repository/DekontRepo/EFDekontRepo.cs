using MEYPAK.DAL.Abstract.DekontDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.DEKONT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.DekontRepo
{
    public class EFDekontRepo : EFBaseRepo<MPDEKONT>, IDekontDal
    {
        MEYPAKContext context;
        public EFDekontRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
