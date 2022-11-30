using AutoMapper;
using MEYPAK.DAL.Abstract.HizmetDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Hizmet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.HIZMET
{
    public class HizmetKategoriManager : BaseManager<PocoHIZMETKATEGORI, MPHIZMETKATEGORI>, IHizmetKategoriServis
    {
        IHizmetKategoriDal _hizmetDal;
        IMapper _mapper;

        public HizmetKategoriManager(IMapper mapper, IHizmetKategoriDal hizmetDal) : base(mapper, hizmetDal)
        {
            _hizmetDal = hizmetDal;
            _mapper = mapper;
        }


        public PocoHIZMETKATEGORI EkleyadaGuncelle(PocoHIZMETKATEGORI pModel)
        {
            return _mapper.Map<MPHIZMETKATEGORI, PocoHIZMETKATEGORI>(_hizmetDal.EkleyadaGuncelle(_mapper.Map<PocoHIZMETKATEGORI, MPHIZMETKATEGORI>(pModel)));

        }
    }
}
