using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFDepoRepo : EFBaseRepo<MPDEPO>, IDepoDal
    {
        MEYPAKContext _context;

        public EFDepoRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }

        public List<MPDEPO> PagingList(int skip, int take)
        {
            return _context.MPDEPO.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }

      


    }
}
