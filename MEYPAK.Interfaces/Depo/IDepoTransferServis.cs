using MEYPAK.Entity.Models;
using MEYPAK.Entity.PocoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Depo
{
    public interface IDepoTransferServis:IGenericServis<MPDEPOTRANSFER>
    {
        public MPDEPOTRANSFER EkleyadaGuncelle(MPDEPOTRANSFER entity);

        public List<PocoDepolarArasıTransfer> PocoDepolarArasıTransferListesi();
    }
}
