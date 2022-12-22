using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.CARI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFCariAltHesRepo : EFBaseRepo<MPCARIALTHES>, ICariAltHesDal
    {
        MEYPAKContext context;
        public EFCariAltHesRepo(MEYPAKContext _context) : base(_context)
        {
           this.context = _context;
        }

    
    }
}


