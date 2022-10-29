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
    public class StokSayimHarManager :BaseManager<PocoSTOKSAYIMHAR,MPSTOKSAYIMHAR> ,IStokSayimHarServis
    {
        IStokSayimHarDal _stokSayimHarDal;
        IMapper _mapper;

        public StokSayimHarManager(IMapper mapper,IStokSayimHarDal stokSayimHarDal) : base(mapper,stokSayimHarDal)
        {
            _stokSayimHarDal = stokSayimHarDal;
            _mapper = mapper;
        }

        public List<PocoSTOKSAYIMHAR> PagingList(int skip, int take)
        {
            return _mapper.Map<List<PocoSTOKSAYIMHAR>>(_stokSayimHarDal.PagingList(skip, take));
        }

        public PocoSTOKSAYIMHAR EkleyadaGuncelle(PocoSTOKSAYIMHAR pModel)
        {
            return _mapper.Map<MPSTOKSAYIMHAR,PocoSTOKSAYIMHAR>( _stokSayimHarDal.EkleyadaGuncelle(_mapper.Map<PocoSTOKSAYIMHAR,MPSTOKSAYIMHAR>(pModel)));
        }

       
    }
}
