using MEYPAK.Entity.PocoModels.FATURA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Fatura
{
    public interface IFaturaDetayServis : IGenericServis<PocoFATURADETAY>
    {
        public PocoFATURADETAY EkleyadaGuncelle(PocoFATURADETAY entity);
    }
}
