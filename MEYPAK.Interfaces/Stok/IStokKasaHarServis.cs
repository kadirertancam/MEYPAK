using MEYPAK.Entity.PocoModels.KASA;
using MEYPAK.Entity.PocoModels.STOK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Kasa
{
    public interface IStokKasaHarServis:IGenericServis<PocoSTOKKASAHAR>
    {
        public PocoSTOKKASAHAR EkleyadaGuncelle(PocoSTOKKASAHAR entity);
    }
}
