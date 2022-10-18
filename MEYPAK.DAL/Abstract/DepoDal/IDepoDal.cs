using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Interfaces;

namespace MEYPAK.DAL.Abstract.DepoDal
{
    public interface IDepoDal : IGeneric<MPDEPO>
    {
        public Durum EkleyadaGuncelle(MPDEPO entity);

    }
}
