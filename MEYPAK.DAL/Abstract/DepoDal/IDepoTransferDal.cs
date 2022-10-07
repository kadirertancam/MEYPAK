using MEYPAK.Entity.Models;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract.DepoDal
{
    public interface IDepoTransferDal:IGeneric<MPDEPOTRANSFER>
    {
        public MPDEPOTRANSFER EkleyadaGuncelle(MPDEPOTRANSFER entity);

        List<PocoDepolarArasıTransfer> PocoDepolarArasıTransferListesi();
    }
}
