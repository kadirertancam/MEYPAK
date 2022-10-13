using MEYPAK.Entity.Models.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokOlcuBrServis:IGenericServis<MPSTOKOLCUBR>
    {
        public Durum EkleyadaGuncelle(MPSTOKOLCUBR entity);
    }
}
