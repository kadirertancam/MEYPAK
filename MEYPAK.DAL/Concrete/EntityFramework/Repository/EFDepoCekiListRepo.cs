using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.DEPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFDepoCekiListRepo : EFBaseRepo<MPDEPOCEKILIST>,IDepoCekiListDal
    {
        MEYPAKContext context;
        public EFDepoCekiListRepo(MEYPAKContext _context) : base(_context)
        {
            context=_context;
        }
    }
}
