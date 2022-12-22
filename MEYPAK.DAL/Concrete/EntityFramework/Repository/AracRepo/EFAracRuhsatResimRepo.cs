using MEYPAK.DAL.Abstract.AracDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.ARAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.AracRepo
{
    public class EFAracRuhsatResimRepo : EFBaseRepo<MPARACRUHSATRESIM>, IAracRuhsatResimDal
    {
        MEYPAKContext _context;
        public EFAracRuhsatResimRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

     
    }
}
