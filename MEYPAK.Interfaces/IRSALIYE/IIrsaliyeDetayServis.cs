using MEYPAK.Entity.Models.FATURA;
using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.IRSALIYE
{
    public interface IIrsaliyeDetayServis:IGenericServis<MPIRSALIYEDETAY>
    {
        public Durum EkleyadaGuncelle(MPIRSALIYEDETAY entity);
    }
}
