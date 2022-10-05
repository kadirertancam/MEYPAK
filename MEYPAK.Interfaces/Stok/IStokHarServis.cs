using MEYPAK.Entity.Models;
using MEYPAK.Entity.PocoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokHarServis:IGenericServis<MPSTOKHAR>
    {
        List<PocoStokHareketListesi> PocoStokHareketListesi(int id);
        public Durum EkleyadaGuncelle(MPSTOKHAR entity);
    }
}
