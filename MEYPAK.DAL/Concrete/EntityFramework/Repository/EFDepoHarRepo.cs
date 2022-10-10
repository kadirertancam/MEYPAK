using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFDepoHarRepo : EFBaseRepo<MPDEPOHAR>,IDepoHarDal
    {
        MEYPAKContext context;

        public EFDepoHarRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
