using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Depo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.DEPO
{
    public class StokMalKabulListManager : BaseManager<MPSTOKMALKABULLIST>, IStokMalKabulListServis
    {
        IStokMalKKabulListDal _stokMalKKabulListDal;
        public StokMalKabulListManager(IStokMalKKabulListDal generic) : base(generic)
        {
            _stokMalKKabulListDal = generic;
        }

        public Durum EkleyadaGuncelle(MPSTOKMALKABULLIST entity)
        {
            return _stokMalKKabulListDal.EkleyadaGuncelle(entity);
        }

        public void OnYukle()
        {
            _stokMalKKabulListDal.OnYukle();
        }
    }
}
