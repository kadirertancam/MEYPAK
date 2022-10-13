using MEYPAK.Entity.Models.PERSONEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Personel
{
    public interface IPersonelServis:IGenericServis<MPPERSONEL>
    {
        public Durum EkleyadaGuncelle(MPPERSONEL entity);
    }
}
