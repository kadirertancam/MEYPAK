using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces.Depo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.DEPO
{
    public class DepoTransferBilgiManager : BaseManager<MPDEPOTRANSFERBILGI>, IDepoTransferBilgiServis
    {
        IDepoTransferBilgiDal _depoTransferBilgiDal;
        public DepoTransferBilgiManager(IDepoTransferBilgiDal generic) : base(generic)
        {
            _depoTransferBilgiDal = generic;
        }

        public MPDEPOTRANSFERBILGI EkleyadaGuncelle(MPDEPOTRANSFERBILGI entity)
        {
            return _depoTransferBilgiDal.EkleyadaGuncelle(entity);
        }
    }
}
