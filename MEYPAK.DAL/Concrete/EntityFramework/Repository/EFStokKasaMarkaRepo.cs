using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokKasaMarkaRepo : EFBaseRepo<MPSTOKKASAMARKA>, IStokKasaMarkaDal
    {
        MEYPAKContext _context;
        public EFStokKasaMarkaRepo(MEYPAKContext _context) : base(_context)
        {
            this._context = _context;
        }

        
    }
}
