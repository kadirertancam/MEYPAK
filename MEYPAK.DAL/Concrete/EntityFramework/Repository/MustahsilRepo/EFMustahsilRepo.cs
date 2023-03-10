using MEYPAK.DAL.Abstract.MüstahsilDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.MUSTAHSIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.MustahsilRepo
{
    public class EFMustahsilRepo : EFBaseRepo<MPMUSTAHSIL>, IMustahsilDal
    {
        public EFMustahsilRepo(MEYPAKContext _context) : base(_context)
        {
        }
    }
}
