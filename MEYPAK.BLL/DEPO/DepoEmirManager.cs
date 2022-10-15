using AutoMapper;
using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Interfaces.Depo;
namespace MEYPAK.BLL.DEPO
{
    public class DepoEmirManager : BaseManager<PocoDEPOEMIR,MPDEPOEMIR>, IDepoEmirServis
    {
        IDepoEmirDal _depoEmirDal;
        IMapper _mapper;

        public DepoEmirManager(IMapper mapper,IDepoEmirDal depoEmirDal) : base(mapper,depoEmirDal)
        {
            _depoEmirDal = depoEmirDal;
            _mapper = mapper;
        }
    }
}
