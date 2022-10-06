using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.STOK
{
    public class StokFiyatListHarManager : BaseManager<MPSTOKFIYATLISTHAR>,IStokFiyatListHarServis
    {
        IStokFiyatListHarDal _stokFiyatListDal;
        public StokFiyatListHarManager(IStokFiyatListHarDal generic) : base(generic)
        {
            this._stokFiyatListDal = generic;
        }

        public MPSTOKFIYATLISTHAR EkleyadaGuncelle(MPSTOKFIYATLISTHAR entity)
        {
            return _stokFiyatListDal.EkleyadaGuncelle(entity);
        }
    }
}
