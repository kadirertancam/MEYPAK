using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFSiparisSevkEmriHarRepo : EFBaseRepo<MPSIPARISSEVKEMRIHAR>, ISiparisSevkEmriHarDal
    {
        MEYPAKContext _context;
        public EFSiparisSevkEmriHarRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
          
        }

        public List<MPSIPARISSEVKEMRIHAR> PagingList(int skip, int take)
        {
            return _context.MPSIPARISSEVKEMRIHAR.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }

     
    }
}
