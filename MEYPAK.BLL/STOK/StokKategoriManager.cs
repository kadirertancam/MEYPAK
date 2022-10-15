using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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

        public Durum EkleyadaGuncelle(PocoSTOKKATEGORI pModel)
        {

            return _kategoriDal.EkleyadaGuncelle(_mapper.Map<PocoSTOKKATEGORI,MPSTOKKATEGORI>(pModel));
        }

       
    }
}
