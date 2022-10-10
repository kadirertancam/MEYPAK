using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFDepoCekiList : EFBaseRepo<MPDEPOCEKILIST>
    {
        MEYPAKContext context;
        public EFDepoCekiList(MEYPAKContext _context) : base(_context)
        {
            context=_context;
        }
    }
}
