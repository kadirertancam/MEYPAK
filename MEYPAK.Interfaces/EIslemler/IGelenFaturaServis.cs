using MEYPAK.Entity.PocoModels.EISLEMLER;
using MEYPAK.Entity.PocoModels.FATURA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.EIslemler
{
    public interface IGelenFaturaServis:IGenericServis<PocoGELENEFATURA>
    {
        public PocoGELENEFATURA EkleyadaGuncelle(PocoGELENEFATURA entity);
    }
}
