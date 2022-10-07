using MEYPAK.DAL.Abstract.PersonelDal;
using MEYPAK.Entity.Models;
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
    public class PersonelManager : IPersonelServis
    {
        IPersonelDal _personelDal;
        public PersonelManager(IPersonelDal personelDal)
        {
            this._personelDal = personelDal;
        }
        public MPPERSONEL Ekle(MPPERSONEL entity)
        {
            return _personelDal.Ekle(entity);
        }

        public Durum EkleyadaGuncelle(MPPERSONEL entity)
        {
            return _personelDal.EkleyadaGuncelle(entity);
        }
 
        public List<MPPERSONEL> Getir(Expression<Func<MPPERSONEL, bool>> predicate)
        {
            return _personelDal.Getir(predicate);
        }

        public Durum Guncelle(MPPERSONEL entity)
        {
            return _personelDal.Guncelle(entity);
        }

        public List<MPPERSONEL> Listele()
        {
            return _personelDal.Listele();
        }

        public bool Sil(Expression<Func<MPPERSONEL, bool>> predicate)
        {
            return _personelDal.Sil(predicate);
        }

        public bool Sil(List<MPPERSONEL> entity)
        {
            return _personelDal.Sil(entity);
        }
    }
}
