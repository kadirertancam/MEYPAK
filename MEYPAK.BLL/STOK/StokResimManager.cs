using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.StokDal;
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
    public class StokResimManager : BaseManager<PocoSTOKRESIM, MPSTOKRESIM>, IStokResimServis
    {
        IStokResimDal _stokResimDal;
        IMapper _mapper;
        public StokResimManager(IMapper mapper, IStokResimDal repo, string includeEntities = null) : base(mapper, repo, includeEntities)
        {
            _stokResimDal = repo;
            _mapper = mapper;
        }
        public PocoSTOKRESIM EkleyadaGuncelle(PocoSTOKRESIM pModel)
        {

            return _mapper.Map<MPSTOKRESIM, PocoSTOKRESIM>(_stokResimDal.EkleyadaGuncelle(_mapper.Map<PocoSTOKRESIM, MPSTOKRESIM>(pModel)));
        }

    }
}
