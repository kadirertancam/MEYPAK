using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces.Depo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.DEPO
{
    public class StokSevkiyatListManager : BaseManager<MPSTOKSEVKİYATLİST>, IStokSevkiyatListServis
    {
        IStokSevkiyatListDal _stokSevkiyatListDal;
        public StokSevkiyatListManager(IStokSevkiyatListDal generic) : base(generic)
        {
            _stokSevkiyatListDal=generic;
        }
    }
}
