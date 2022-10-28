using AutoMapper;
using MEYPAK.DAL;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.DEPO;
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
    public class StokManager :BaseManager<PocoSTOK,MPSTOK>, IStokServis
    {
        IStokDal _stokDal;
        IMapper _mapper;

        public StokManager(IMapper mapper,IStokDal stokDal) : base(mapper,stokDal)
        {
            _stokDal = stokDal;
            _mapper = mapper;
        }

        public List<PocoSTOK> PagingList(int skip, int take, bool requireTotalCount )
        {
            return  _mapper.Map<List<PocoSTOK>>(_stokDal.PagingList(skip, take, requireTotalCount));
        }

        public PocoSTOK EkleyadaGuncelle(PocoSTOK pModel)
        {
            return _mapper.Map<MPSTOK,PocoSTOK>( _stokDal.EkleyadaGuncelle(_mapper.Map<PocoSTOK,MPSTOK>(pModel)));
        }

        public List<PocoSTOK> Listee()
        {
            
            return _mapper.Map<List<PocoSTOK>>(_stokDal.Listele());
        }

    }
}
