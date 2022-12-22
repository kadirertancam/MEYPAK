using MEYPAK.DAL.Abstract.FaturaDal;
using MEYPAK.DAL.Abstract.IrsaliyeDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.FATURA;
using MEYPAK.Entity.Models.IRSALIYE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.FaturaRepo
{
    public class EFFaturaRepo : EFBaseRepo<MPFATURA>, IFaturaDal
    {
        MEYPAKContext _context;

        public EFFaturaRepo(MEYPAKContext context) : base(context)
        {
            _context = context; 
        }


    
    }
}
