using MEYPAK.DAL.Abstract.AracDal;
using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.ARAC;
using MEYPAK.Entity.Models.CARI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.AracRepo
{
    public class EFAracRotaRepo : EFBaseRepo<MPARACROTA>, IAracRotaDal
    {
        MEYPAKContext _context;
        public EFAracRotaRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

    
}
}
