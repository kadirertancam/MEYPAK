using MEYPAK.DAL;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models;
using MEYPAK.Entity.PocoModels;
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
    public class StokHarManager :BaseManager<MPSTOKHAR>, IStokHarServis
    {
        IStokHarDal _stokHarDal;

        public StokHarManager(IStokHarDal generic) : base(generic)
        {
            _stokHarDal = generic;
        }

  

        public Durum EkleyadaGuncelle(MPSTOKHAR entity)
        {
            return _stokHarDal.EkleyadaGuncelle(entity);
        }

        public List<PocoStokHareketListesi> PocoStokHareketListesi(int id)
        {
            return _stokHarDal.PocoStokHareketListesi(id);
        }

    }
}
