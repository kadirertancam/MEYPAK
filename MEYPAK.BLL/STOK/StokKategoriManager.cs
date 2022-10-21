using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Stok;

namespace MEYPAK.BLL.STOK
{
    public class StokKategoriManager :BaseManager<PocoSTOKKATEGORI,MPSTOKKATEGORI>, IStokKategoriServis
    {
        IStokKategoriDal _kategoriDal;
        IMapper _mapper;

        public StokKategoriManager(IMapper mapper,IStokKategoriDal stokKategoriDal) : base(mapper, stokKategoriDal)
        {
            _kategoriDal = stokKategoriDal;
            _mapper = mapper;
        }

        public PocoSTOKKATEGORI EkleyadaGuncelle(PocoSTOKKATEGORI pModel)
        {

            return _mapper.Map<MPSTOKKATEGORI,PocoSTOKKATEGORI>( _kategoriDal.EkleyadaGuncelle(_mapper.Map<PocoSTOKKATEGORI,MPSTOKKATEGORI>(pModel)));
        }

       
    }
}
