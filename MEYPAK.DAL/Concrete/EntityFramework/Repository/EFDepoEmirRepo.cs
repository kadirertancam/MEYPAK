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
    public class EFDepoEmirRepo : EFBaseRepo<MPDEPOEMIR>,IDepoEmirDal
    {
        MEYPAKContext context;
        public EFDepoEmirRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
