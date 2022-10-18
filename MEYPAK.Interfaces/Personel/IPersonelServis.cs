using MEYPAK.Entity.Models.PERSONEL;

namespace MEYPAK.Interfaces.Personel
{
    public interface IPersonelServis:IGenericServis<MPPERSONEL>
    {
        public Durum EkleyadaGuncelle(MPPERSONEL entity);
    }
}
