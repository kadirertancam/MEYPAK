using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.Models.DEPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFADRESLISTREPO : EFBaseRepo<ADRESLIST>, IAdresListDal
    {
        public EFADRESLISTREPO(MEYPAKContext _context) : base(_context)
        {
           
        }
    }
}
