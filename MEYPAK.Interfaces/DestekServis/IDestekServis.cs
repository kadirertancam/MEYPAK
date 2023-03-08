using MEYPAK.Entity.PocoModels.DESTEKSERVIS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.DestekServis
{
    public interface IDestekServis : IGenericServis<PocoDestekServis>
    {
        public PocoDestekServis EkleyadaGuncelle(PocoDestekServis entity);
    }
}
