using MEYPAK.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokFiyatListServis:IGenericServis<MPSTOKFIYATLIST>
    {
        public MPSTOKFIYATLIST EkleyadaGuncelle(MPSTOKFIYATLIST entity);
    }
}
