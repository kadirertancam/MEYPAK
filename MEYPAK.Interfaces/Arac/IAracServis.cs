using MEYPAK.Entity.Models.ARAC;
using MEYPAK.Entity.PocoModels.ARAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Arac
{
    public interface IAracServis:IGenericServis<PocoARACLAR>
    {
        public PocoARACLAR EkleyadaGuncelle(PocoARACLAR entity);
    }
}
