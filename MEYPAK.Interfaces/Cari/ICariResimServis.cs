using MEYPAK.Entity.PocoModels.CARI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Cari
{
    public interface ICariResimServis:IGenericServis<PocoCARIRESIM>
    {
        public PocoCARIRESIM EkleyadaGuncelle(PocoCARIRESIM entity);
    }
}
