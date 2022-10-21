using MEYPAK.Entity.Models.DEPO;

namespace MEYPAK.DAL.Abstract.StokDal
{
    public interface IDepoCekiListDal:IGeneric<MPDEPOCEKILIST>
    {
        public MPDEPOCEKILIST EkleyadaGuncelle(MPDEPOCEKILIST entity);
    }
}
