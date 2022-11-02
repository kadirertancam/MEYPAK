using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.PocoModels.PERSONEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Parametre
{
    public interface IParaBirimServis:IGenericServis<PocoPARABIRIM>
    {
        public PocoPARABIRIM EkleyadaGuncelle(PocoPARABIRIM entity);
    }
}
