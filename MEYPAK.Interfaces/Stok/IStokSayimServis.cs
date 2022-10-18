using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokSayimServis:IGenericServis<PocoSTOKSAYIM>
    {
        public Durum EkleyadaGuncelle(PocoSTOKSAYIM entity);

        public IQueryable<MPSTOKSAYIM> Listee();
    }
}
