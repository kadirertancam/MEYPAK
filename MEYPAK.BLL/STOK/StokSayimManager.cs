using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.STOK
{
    public class StokSayimManager :BaseManager<MPSTOKSAYIM> ,IStokSayimServis
    {
        IStokSayimDal _stokSayimDal;

        public StokSayimManager(IStokSayimDal generic) : base(generic)
        {
            _stokSayimDal = generic;
        }

    

        public Durum EkleyadaGuncelle(MPSTOKSAYIM entity)
        {
            return _stokSayimDal.EkleyadaGuncelle(entity);
        }

    }
}
