using MEYPAK.DAL.Abstract.KasaDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.KASA;
using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokKasaHarRepo : EFBaseRepo<MPSTOKKASAHAR>, IStokKasaHarDal
    {
        MEYPAKContext _context;
        public EFStokKasaHarRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

   
    }
}
