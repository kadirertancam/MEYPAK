using MEYPAK.DAL.Abstract.CekSenetDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.CEKSENET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.CekSenetRepo
{
    public class EFMusteriSenetHarRepo : EFBaseRepo<MPMUSTERISENETHAR>, IMusteriSenetHarDal
    {
        MEYPAKContext context;
        public EFMusteriSenetHarRepo(MEYPAKContext _context) : base(_context)
        {
            context= _context;
        }
    }
}
