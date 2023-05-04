using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.DAL.Abstract.FaturaDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.Models.FATURA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFFaturaStokEsleRepo : EFBaseRepo<MPFATURASTOKESLE>, IFaturaStokEsleDal
    {
        MEYPAKContext context;
        public EFFaturaStokEsleRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
