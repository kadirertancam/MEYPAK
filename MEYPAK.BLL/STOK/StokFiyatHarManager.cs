using AutoMapper;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.STOK
{
    public class StokFiyatHarManager : BaseManager<PocoSTOKFIYATHAR, MPSTOKFIYATHAR>, IStokFiyatHarServis
    {
        IStokFiyatHarDal _stokFiyatHarDal;
        IMapper _mapper;

        public StokFiyatHarManager(IMapper mapper, IStokFiyatHarDal stokFiyatHarDal) : base(mapper, stokFiyatHarDal)
        {
            _stokFiyatHarDal = stokFiyatHarDal;
            _mapper = mapper;
        }

        public List<PocoSTOKFIYATHAR> PagingList(int skip, int take)
        {
            return _mapper.Map<List<PocoSTOKFIYATHAR>>(_stokFiyatHarDal.PagingList(skip, take));
        }

        public PocoSTOKFIYATHAR EkleyadaGuncelle(PocoSTOKFIYATHAR pModel)
        {
            return _mapper.Map<MPSTOKFIYATHAR, PocoSTOKFIYATHAR>(_stokFiyatHarDal.EkleyadaGuncelle(_mapper.Map<PocoSTOKFIYATHAR, MPSTOKFIYATHAR>(pModel)));
        }
    }
}
