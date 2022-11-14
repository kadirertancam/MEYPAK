using MEYPAK.Entity.PocoModels.KASA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Kasa
{
    public interface IKasaServis:IGenericServis<PocoKASA>
    {
        public PocoKASA EkleyadaGuncelle(PocoKASA entity);
    }
}
