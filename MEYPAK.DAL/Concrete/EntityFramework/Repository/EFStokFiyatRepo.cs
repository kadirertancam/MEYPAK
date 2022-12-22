using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokFiyatRepo : EFBaseRepo<MPSTOKFIYAT>, IStokFiyatDal
    {
        MEYPAKContext _context;

        public EFStokFiyatRepo(MEYPAKContext context) : base(context)
        {
            _context = context; 
        }

    

        public List<MPSTOKFIYAT> PagingList(int skip, int take)
        {
             return _context.MPSTOKFIYAT.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }
    }
}
