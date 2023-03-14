using MEYPAK.DAL.Abstract.MustahsilDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.MUSTAHSIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.MustahsilRepo
{
    public class EFMustahsilDetayRepo : EFBaseRepo<MPMUSTAHSILDETAY>, IMustahsilDetayDal
    {
        public EFMustahsilDetayRepo(MEYPAKContext _context) : base(_context)
        {
        }
    }
}
