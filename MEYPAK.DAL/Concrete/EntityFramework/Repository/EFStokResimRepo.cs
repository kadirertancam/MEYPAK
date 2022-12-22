using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokResimRepo : EFBaseRepo<MPSTOKRESIM>, IStokResimDal
    {
        MEYPAKContext context;
        public EFStokResimRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }
       

    }
}
