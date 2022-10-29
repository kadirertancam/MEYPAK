using AutoMapper;
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
    public class StokOlcuBrManager :BaseManager<PocoSTOKOLCUBR,MPSTOKOLCUBR> ,IStokOlcuBrServis
    {
        IStokOlcuBrDal _stokOlcuBrDal;
        IMapper _mapper;

        public StokOlcuBrManager(IMapper mapper, IStokOlcuBrDal stokOlcuBrDal) : base(mapper,stokOlcuBrDal)
        {
            _stokOlcuBrDal = stokOlcuBrDal;
            _mapper = mapper;   
        }


        public List<PocoSTOKOLCUBR> PagingList(int skip, int take)
        {
            return _mapper.Map<List<PocoSTOKOLCUBR>>(_stokOlcuBrDal.PagingList(skip, take));
        }
        public PocoSTOKOLCUBR EkleyadaGuncelle(PocoSTOKOLCUBR pModel)
        {
            return _mapper.Map<MPSTOKOLCUBR,PocoSTOKOLCUBR>( _stokOlcuBrDal.EkleyadaGuncelle(_mapper.Map<PocoSTOKOLCUBR,MPSTOKOLCUBR>(pModel)));
        }

    }
}
