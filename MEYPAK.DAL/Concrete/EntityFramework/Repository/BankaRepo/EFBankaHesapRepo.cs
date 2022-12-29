using MEYPAK.DAL.Abstract.BankaDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.BANKA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.BankaRapo
{
    public class EFBankaHesapRepo : EFBaseRepo<MPBANKAHESAP>, IBankaHesapDal
    {
        MEYPAKContext context;
        public EFBankaHesapRepo(MEYPAKContext _context) : base(_context)
        {
            context = _context;
        }
    }
}
