using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels.DEPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Depo
{
    public interface IDepoEmirServis:IGenericServis<PocoDEPOEMIR>
    {
        public PocoDEPOEMIR EkleyadaGuncelle(PocoDEPOEMIR entity);
    }
}
