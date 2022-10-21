using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Entity.PocoModels.PERSONEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.Interfaces.Personel
{
    public interface IPersonelServis:IGenericServis<PocoPERSONEL>
    {
        public PocoPERSONEL EkleyadaGuncelle(PocoPERSONEL entity);
    }
}
