using MEYPAK.Entity.Models.DEPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Depo
{
    public interface IDepoTransferHarServis:IGenericServis<MPDEPOTRANSFERHAR>
    {
        public MPDEPOTRANSFERHAR EkleyadaGuncelle(MPDEPOTRANSFERHAR entity);
    }
}
