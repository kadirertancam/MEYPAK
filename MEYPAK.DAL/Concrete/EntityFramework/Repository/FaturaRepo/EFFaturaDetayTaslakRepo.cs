using MEYPAK.DAL.Abstract.FaturaDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.FATURA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.FaturaRepo
{
    public class EFFaturaDetayTaslakRepo : EFBaseRepo<MPFATURADETAYTASLAK>, IFaturaDetayTaslakDal
    {
        public EFFaturaDetayTaslakRepo(MEYPAKContext _context) : base(_context)
        {
        }
    }
}
