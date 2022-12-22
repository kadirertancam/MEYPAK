using MEYPAK.Entity.PocoModels.KASA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Kasa
{
    public interface IKasaHarServis : IGenericServis<PocoKASAHAR>
    {
        public PocoKASAHAR EkleyadaGuncelle(PocoKASAHAR entity);
    }
}
