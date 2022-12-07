using MEYPAK.Entity.PocoModels.PARAMETRE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Parametre
{
    public interface ISeriHarServis:IGenericServis<PocoSERIHAR>
    {
        public PocoSERIHAR EkleyadaGuncelle(PocoSERIHAR entity);
    }
}
