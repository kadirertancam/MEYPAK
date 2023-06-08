using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.CARI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.CariRepo
{
    public class EFHksBeldelerRepo : EFBaseRepo<MPHKSBELDELER>, IHksBeldelerDal
    {
        MEYPAKContext _context;
        public EFHksBeldelerRepo(MEYPAKContext context) : base(context)
        {
            _context=context;
        }
    }
}
