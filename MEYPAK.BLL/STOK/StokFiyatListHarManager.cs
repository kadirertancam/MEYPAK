using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;

namespace MEYPAK.BLL.STOK
{
    public class StokFiyatListHarManager : BaseManager<PocoSTOKFIYATLISTHAR,MPSTOKFIYATLISTHAR>,IStokFiyatListHarServis
    {
        IStokFiyatListHarDal _stokFiyatListHarDal;
        IMapper _mapper;
        public StokFiyatListHarManager(IMapper mapper,IStokFiyatListHarDal stokFiyatListHarDal) : base(mapper,stokFiyatListHarDal)
        {
            this._stokFiyatListHarDal = stokFiyatListHarDal;
            _mapper = mapper;
        }


        public List<PocoSTOKFIYATLISTHAR> PagingList(int skip, int take)
        {
            return _mapper.Map<List<PocoSTOKFIYATLISTHAR>>(_stokFiyatListHarDal.PagingList(skip, take));
        }
        public PocoSTOKFIYATLISTHAR EkleyadaGuncelle(PocoSTOKFIYATLISTHAR pModel)
        {
            
            return _mapper.Map<MPSTOKFIYATLISTHAR,PocoSTOKFIYATLISTHAR>(_stokFiyatListHarDal.EkleyadaGuncelle(_mapper.Map<PocoSTOKFIYATLISTHAR, MPSTOKFIYATLISTHAR>(pModel)));
        }
      
    }
}
