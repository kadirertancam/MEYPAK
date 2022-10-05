using MEYPAK.DAL;
using MEYPAK.DAL.Abstract;
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
    public class StokManager :BaseManager<MPSTOK>, IStokServis
    {
        IStokDal _stokDal;

        public StokManager(IStokDal generic) : base(generic)
        {
            _stokDal = generic;
        }

  

        public Durum EkleyadaGuncelle(MPSTOK entity)
        {
            return _stokDal.EkleyadaGuncelle(entity);
        }

    }
}
