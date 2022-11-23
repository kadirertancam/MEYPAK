using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Fatura
{
    public interface IFaturaServis : IGenericServis<PocoFATURA>
    {
        public PocoFATURA EkleyadaGuncelle(PocoFATURA entity);
    }
}
