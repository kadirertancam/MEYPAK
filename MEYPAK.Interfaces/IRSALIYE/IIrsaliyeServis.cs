using MEYPAK.Entity.Models.IRSALIYE;

namespace MEYPAK.Interfaces.IRSALIYE
{
    public interface IIrsaliyeServis:IGenericServis<MPIRSALIYE>
    {
        public Durum EkleyadaGuncelle(MPIRSALIYE entity);
    }
}
