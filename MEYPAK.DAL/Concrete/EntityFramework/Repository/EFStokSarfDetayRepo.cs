using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokSarfDetayRepo : EFBaseRepo<MPSTOKSARFDETAY>, IStokSarfDetayDal
    {
        public EFStokSarfDetayRepo(MEYPAKContext _context) : base(_context)
        {
        }
    }
}
