using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.CARI;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFCariYetkiliRepo : EFBaseRepo<MPCARIYETKILI>, ICariYetkiliDal
    { 
        MEYPAKContext _context;

        public EFCariYetkiliRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

     
    }


}
