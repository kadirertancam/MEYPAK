using MEYPAK.DAL.Abstract.KasaDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.KASA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.KasaRepo
{
    public class EFKasaHarRepo : EFBaseRepo<MPKASAHAR>, IKasaHarDal
    {
        MEYPAKContext _context;
        public EFKasaHarRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }
    }
}
