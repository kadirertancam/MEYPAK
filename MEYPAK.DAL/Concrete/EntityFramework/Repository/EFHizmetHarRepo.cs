using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFHizmetHarRepo : EFBaseRepo<MPHIZMETHAR>, IHizmetHarDal
    {
        MEYPAKContext context;
        public EFHizmetHarRepo(MEYPAKContext _context) : base(_context)
        {
            this.context = _context;
        }
    }
}
