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
    public class StokSayimManager :BaseManager<PocoSTOKSAYIM,MPSTOKSAYIM> ,IStokSayimServis
    {
        IStokSayimDal _stokSayimDal;
        IMapper _mapper;

        public StokSayimManager(IMapper mapper,IStokSayimDal stokSayimDal) : base(mapper,stokSayimDal)
        {
            _stokSayimDal = stokSayimDal;
            _mapper=mapper;
        }

    

        public PocoSTOKSAYIM EkleyadaGuncelle(PocoSTOKSAYIM pModel)
        {
            return _mapper.Map<MPSTOKSAYIM,PocoSTOKSAYIM>( _stokSayimDal.EkleyadaGuncelle(_mapper.Map<PocoSTOKSAYIM,MPSTOKSAYIM>(pModel)));
        }


        public IQueryable<MPSTOKSAYIM> Listee()
        {
            return _stokSayimDal.Listee();
        }
    }
}
