using MEYPAK.DAL.Abstract.FormYetkiDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.FORMYETKI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.FormYetkiRepo
{
    public class EFFormYetkiRepo : EFBaseRepo<MPFORMYETKI>, IFormYetkiDal
    {
        MEYPAKContext context;
        public EFFormYetkiRepo(MEYPAKContext _context) : base(_context)
        {
            context= _context;
        }
    }
}
