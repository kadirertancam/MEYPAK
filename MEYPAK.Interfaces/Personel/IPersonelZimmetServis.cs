using MEYPAK.Entity.PocoModels.PERSONEL;

namespace MEYPAK.Interfaces.Personel
{
    public interface IPersonelZimmetServis:IGenericServis<PocoPERSONELZIMMET>
    {
        public PocoPERSONELZIMMET EkleyadaGuncelle(PocoPERSONELZIMMET entity);
    }
}
