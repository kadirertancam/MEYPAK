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
    public class DepoTransferManager : BaseManager<MPDEPOTRANSFER>, IDepoTransferServis
    {
        IDepoTransferDal _depoTransferDal;
        public DepoTransferManager(IDepoTransferDal generic) : base(generic)
        {
            _depoTransferDal = generic;
        }

        public MPDEPOTRANSFER EkleyadaGuncelle(MPDEPOTRANSFER entity)
        {
            return _depoTransferDal.EkleyadaGuncelle(entity);
        }
    }
}
