using MEYPAK.Entity.Models.FATURA;
using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.IRSALIYE
{
    public interface IIrsaliyeServis:IGenericServis<MPIRSALIYE>
    {
        public Durum EkleyadaGuncelle(MPIRSALIYE entity);
    }
}
