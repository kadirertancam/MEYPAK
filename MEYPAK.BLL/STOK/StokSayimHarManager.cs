using MEYPAK.DAL.Abstract;
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
    public class StokSayimHarManager :BaseManager<MPSTOKSAYIMHAR> ,IStokSayimHarServis
    {
        IStokSayimHarDal _stokSayimHarDal;

        public StokSayimHarManager(IStokSayimHarDal generic) : base(generic)
        {
            _stokSayimHarDal = generic;
        }

      

        public Durum EkleyadaGuncelle(MPSTOKSAYIMHAR entity)
        {
            return _stokSayimHarDal.EkleyadaGuncelle(entity);
        }

       
    }
}
