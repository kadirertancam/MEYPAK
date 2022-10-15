using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Stok
{
    public interface IStokServis:IGenericServis<PocoSTOK>
    {
        public Durum EkleyadaGuncelle(PocoSTOK entity);

        public IQueryable<MPSTOK> Listee();
    }
}
