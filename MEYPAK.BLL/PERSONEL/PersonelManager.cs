using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.PersonelDal;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Personel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.PERSONEL
{
    public class PersonelManager :BaseManager<MPPERSONEL> ,IPersonelServis
    {
        IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal generic) : base(generic)
        {
            _personelDal = generic;
        }


        public Durum EkleyadaGuncelle(MPPERSONEL entity)
        {
            return _personelDal.EkleyadaGuncelle(entity);
        }


    }
}
