using MEYPAK.Entity.Models.IRSALIYE;

namespace MEYPAK.Interfaces.IRSALIYE
{
    public interface IIrsaliyeDetayServis:IGenericServis<MPIRSALIYEDETAY>
    {
        public Durum EkleyadaGuncelle(MPIRSALIYEDETAY entity);
    }
}
