using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Interfaces;

namespace MEYPAK.DAL.Abstract.PersonelDal
{
    public interface IPersonelDal:IGeneric<MPPERSONEL>
    {

        public Durum EkleyadaGuncelle(MPPERSONEL entity);
    }
}
