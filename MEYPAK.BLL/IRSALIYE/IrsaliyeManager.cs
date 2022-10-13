using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces.Stok;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEYPAK.Entity.Models.FATURA;
using MEYPAK.DAL.Abstract.IrsaliyeDal;
using MEYPAK.Interfaces.IRSALIYE;

namespace MEYPAK.BLL.IRSALIYE
{
    public class IrsaliyeManager : BaseManager<MPIRSALIYE>, IIrsaliyeServis
    {
        IIrsaliyeDal _stokDal;

        public IrsaliyeManager(IIrsaliyeDal generic) : base(generic)
        {
            _stokDal = generic;
        }



        public Durum EkleyadaGuncelle(MPIRSALIYE entity)
        {
            return _stokDal.EkleyadaGuncelle(entity);
        }
    }
}
