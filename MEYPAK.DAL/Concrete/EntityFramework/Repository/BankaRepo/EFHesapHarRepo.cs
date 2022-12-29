using MEYPAK.DAL.Abstract.BankaDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.BANKA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.BankaRepo
{
    public class EFHesapHarRepo : EFBaseRepo<MPHESAPHAREKET>, IHesapHarDal
    {
        MEYPAKContext context;
        public EFHesapHarRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
