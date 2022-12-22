using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
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
    public class EFStokSayimRepo : EFBaseRepo<MPSTOKSAYIM>, IStokSayimDal
    {
        MEYPAKContext _context;

        public EFStokSayimRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
            
        }
        public List<MPSTOKSAYIM> PagingList(int skip, int take)
        {
            return _context.MPSTOKSAYIM.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }


      
       


    }
}
