using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.STOK
{
    public class StokFiyatListManager : BaseManager<MPSTOKFIYATLIST>,IStokFiyatListServis
    {
        IStokFiyatListDal _stokFiyatListDal;
        public StokFiyatListManager(IStokFiyatListDal generic) : base(generic)
        {
            _stokFiyatListDal = generic;
        }

        public Durum EkleyadaGuncelle(MPSTOKFIYATLIST entity)
        {
            return _stokFiyatListDal.EkleyadaGuncelle(entity);
        }
    }
}
