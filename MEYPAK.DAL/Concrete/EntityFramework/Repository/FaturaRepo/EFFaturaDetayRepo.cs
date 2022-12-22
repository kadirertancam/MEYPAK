using MEYPAK.DAL.Abstract.FaturaDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.FATURA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.FaturaRepo
{
    public class EFFaturaDetayRepo: EFBaseRepo<MPFATURADETAY>, IFaturaDetayDal
    {
        MEYPAKContext _context;

        public EFFaturaDetayRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }


    
    
    }
}
