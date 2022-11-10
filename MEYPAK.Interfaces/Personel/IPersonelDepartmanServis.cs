using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.PERSONEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Personel
{
    public interface IPersonelDepartmanServis:IGenericServis<PocoPERSONELDEPARTMAN>
    {
        public PocoPERSONELDEPARTMAN EkleyadaGuncelle(PocoPERSONELDEPARTMAN entity);
    }
}
