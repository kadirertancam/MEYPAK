using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.DAL.Abstract.PersonelDal
{
    public interface IPersonelDal:IGeneric<MPPERSONEL>
    {

        public Durum EkleyadaGuncelle(MPPERSONEL entity);
    }
}
