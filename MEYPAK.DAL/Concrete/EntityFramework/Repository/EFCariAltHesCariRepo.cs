using MEYPAK.DAL.Abstract.CariDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.CARI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFCariAltHesCariRepo : EFBaseRepo<MPCARIALTHESCARI>, ICariAltHesCariDal
    {
        MEYPAKContext _mEYPAKContext;
        public EFCariAltHesCariRepo(MEYPAKContext _context) : base(_context)
        {
            _mEYPAKContext = _context;
        }

        public MPCARIALTHESCARI EkleyadaGuncelle(MPCARIALTHESCARI entity)
        {
            throw new NotImplementedException();
        }
    }
}
