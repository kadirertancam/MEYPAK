using MEYPAK.DAL.Abstract.EIslemlerDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.EISLEMLER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFGidenFaturalarRepo : EFBaseRepo<MPGIDENFATURALAR>, IGidenFaturalarDal
    {
        MEYPAKContext context;
        public EFGidenFaturalarRepo(MEYPAKContext _context) : base(_context)
        {
            context=_context;
        }
    }
}
