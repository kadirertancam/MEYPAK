using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Interfaces.Depo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.DEPO
{
    public class DepoTransferHarManager : BaseManager<MPDEPOTRANSFERHAR>, IDepoTransferHarServis
    {
        IDepoTransferHarDal _depoTransferHarDal;
        public DepoTransferHarManager(IDepoTransferHarDal generic) : base(generic)
        {
            _depoTransferHarDal = generic;
        }

        public MPDEPOTRANSFERHAR EkleyadaGuncelle(MPDEPOTRANSFERHAR entity)
        {
            return _depoTransferHarDal.EkleyadaGuncelle(entity);
        }
    }
}
