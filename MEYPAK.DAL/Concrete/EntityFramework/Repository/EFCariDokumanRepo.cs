using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.CARI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFCariDokumanRepo : EFBaseRepo<MPCARIDOKUMAN>, ICariDokumanDal
    {
        MEYPAKContext context;
        public EFCariDokumanRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }

         
        } 
}

