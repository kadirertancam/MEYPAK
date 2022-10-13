using MEYPAK.Entity.Models.DEPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Depo
{
    public interface IDepoServis : IGenericServis<MPDEPO>
    {
        public Durum EkleyadaGuncelle(MPDEPO entity);
    }
}
