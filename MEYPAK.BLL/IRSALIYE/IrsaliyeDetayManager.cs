using MEYPAK.DAL.Abstract.IrsaliyeDal;
using MEYPAK.Interfaces.Stok;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEYPAK.Interfaces.IRSALIYE;
using MEYPAK.Entity.Models.IRSALIYE;

namespace MEYPAK.BLL.IRSALIYE
{
    public class IrsaliyeDetayManager : BaseManager<MPIRSALIYEDETAY>, IIrsaliyeDetayServis
    {
        IIrsaliyeDetayDal _stokDal;

        public IrsaliyeDetayManager(IIrsaliyeDetayDal generic) : base(generic)
        {
            _stokDal = generic;
        }



        public Durum EkleyadaGuncelle(MPIRSALIYEDETAY entity)
        {
            return _stokDal.EkleyadaGuncelle(entity);
        }
    }
}
