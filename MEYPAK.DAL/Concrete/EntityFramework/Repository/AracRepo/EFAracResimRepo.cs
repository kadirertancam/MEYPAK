using MEYPAK.DAL.Abstract.AracDal;
using MEYPAK.DAL.Abstract.KasaDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.ARAC;
using MEYPAK.Entity.Models.KASA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.AracRepo
{
    public class EFAracResimRepo : EFBaseRepo<MPARACRESIM>, IAracResimDal
    {
        MEYPAKContext _context;
        public EFAracResimRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

      
    }
}
