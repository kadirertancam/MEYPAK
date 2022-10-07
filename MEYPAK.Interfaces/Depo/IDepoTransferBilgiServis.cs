using MEYPAK.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Depo
{
    public interface IDepoTransferBilgiServis:IGenericServis<MPDEPOTRANSFERBILGI>
    {
        public MPDEPOTRANSFERBILGI EkleyadaGuncelle(MPDEPOTRANSFERBILGI entity);
    }
}
