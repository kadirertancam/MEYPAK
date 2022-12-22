using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.DEPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFDepoEmirRepo : EFBaseRepo<MPDEPOEMIR>,IDepoEmirDal
    {
        MEYPAKContext _context;
        public EFDepoEmirRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

        public List<MPDEPOEMIR> PagingList(int skip, int take)
        {
            return _context.MPDEPOEMIR.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }

     
    }
}
