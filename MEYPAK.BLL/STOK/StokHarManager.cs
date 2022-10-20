using AutoMapper;
using MEYPAK.DAL;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
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
    public class StokHarManager :BaseManager<PocoSTOKHAR,MPSTOKHAR>, IStokHarServis
    {
        IStokHarDal _stokHarDal;
        IMapper _mapper;

        public StokHarManager(IMapper mapper,IStokHarDal stokHarDal) : base(mapper,stokHarDal)
        {
            _stokHarDal = stokHarDal;
            _mapper = mapper;
        }

  

        public PocoSTOKHAR EkleyadaGuncelle(PocoSTOKHAR pModel)
        {
        
           
            return  _mapper.Map<MPSTOKHAR,PocoSTOKHAR>(_stokHarDal.EkleyadaGuncelle(_mapper.Map<PocoSTOKHAR, MPSTOKHAR>(pModel)));
        }

        public List<PocoStokHareketListesi> PocoStokHareketListesi(int id)
        {
            return _stokHarDal.PocoStokHareketListesi(id);
        }

        void Sil(int id)
        {
             _stokHarDal.Sil(id);
        }

    }
}
