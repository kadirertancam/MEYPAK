using MEYPAK.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokSayimServis:IGenericServis<MPSTOKSAYIM>
    {
        public Durum EkleyadaGuncelle(MPSTOKSAYIM entity);
    }
}
