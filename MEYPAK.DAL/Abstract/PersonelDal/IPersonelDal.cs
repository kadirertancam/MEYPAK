using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Interfaces;

namespace MEYPAK.DAL.Abstract.PersonelDal
{
    public interface IPersonelDal:IGeneric<MPPERSONEL>
    {

        public MPPERSONEL EkleyadaGuncelle(MPPERSONEL entity);
    }
}
