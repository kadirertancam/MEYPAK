using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.IRSALIYE
{
    public interface IIrsaliyeServis:IGenericServis<PocoIRSALIYE>
    {
        public Durum EkleyadaGuncelle(PocoIRSALIYE entity);
    }
}
