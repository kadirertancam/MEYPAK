using MEYPAK.Entity.PocoModels.ARAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Arac
{
    public interface IAraclarServis : IGenericServis<PocoARACLAR>
    {
        public PocoARACLAR EkleyadaGuncelle(PocoARACLAR entity);
    }
}
