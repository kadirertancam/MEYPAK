using AutoMapper;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;

namespace MEYPAK.BLL.STOK
{
    public class StokSarfDetayManager : BaseManager<PocoSTOKSARFDETAY, MPSTOKSARFDETAY>, IStokSarfDetayServis
    {
        public StokSarfDetayManager(IMapper mapper, IStokSarfDetayDal repo, string includeEntities = null) : base(mapper, repo, includeEntities)
        {
        }
    }
}
