using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Concrete.EntityFramework.Repository
{
    public class EFStokSevkiyatListRepo : EFBaseRepo<MPSTOKSEVKİYATLİST>, IStokSevkiyatListDal
    {
        MEYPAKContext _context;
        public EFStokSevkiyatListRepo(MEYPAKContext context) : base(context)
        {
            _context = context;
        }
        public List<MPSTOKSEVKİYATLİST> PagingList(int skip, int take)
        {
            return _context.MPSTOKSEVKİYATLİST.Where(x => x.ID > skip && x.KAYITTIPI == (byte)0).Take(take).ToList();
        }
        public List<MPSTOKSEVKİYATLİST> PagingList(int skip, int take, int requireTotalCount=0)
        {
           return _context.MPSTOKSEVKİYATLİST.Where(x => x.ID > skip && x.KAYITTIPI==0).Take(take).ToList();
        }
    }
}
