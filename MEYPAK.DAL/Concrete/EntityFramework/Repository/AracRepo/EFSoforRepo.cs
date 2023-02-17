using MEYPAK.DAL.Abstract.AracDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.ARAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository.AracRepo
{
    public class EFSoforRepo : EFBaseRepo<MPSOFOR>, ISoforDal
    {
        MEYPAKContext _context;
        public EFSoforRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

    }
}
