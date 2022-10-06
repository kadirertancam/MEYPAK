using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models;
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
    public class StokOlcuBrManager :BaseManager<MPSTOKOLCUBR> ,IStokOlcuBrServis
    {
        IStokOlcuBrDal _stokOlcuBrDal;

        public StokOlcuBrManager(IStokOlcuBrDal generic) : base(generic)
        {
            _stokOlcuBrDal = generic;
        }


        public Durum EkleyadaGuncelle(MPSTOKOLCUBR entity)
        {
            return _stokOlcuBrDal.EkleyadaGuncelle(entity);
        }

    }
}
