using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.EISLEMLER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.EIslemlerRepo
{
    public class EFGelenEFaturaRepo : EFBaseRepo<MPGELENEFATURA>
    {
        MEYPAKContext context;
        public EFGelenEFaturaRepo(MEYPAKContext _context) : base(_context)
        {
            this.context = _context;
        }
    }
}
