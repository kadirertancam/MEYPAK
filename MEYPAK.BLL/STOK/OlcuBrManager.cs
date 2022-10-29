using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.SiparisDal;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.SIPARIS;
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
    public class OlcuBrManager :BaseManager<PocoOLCUBR,MPOLCUBR> ,IOlcuBrServis
    {
        IOlcuBrDal _olcuBrDal;
        IMapper _mapper;
        public OlcuBrManager(IMapper mapper,IOlcuBrDal olcuBrDal) : base(mapper, olcuBrDal)
        {
            _olcuBrDal = olcuBrDal;
            _mapper = mapper;
        }

        public List<PocoOLCUBR> PagingList(int skip, int take)
        {
            return _mapper.Map<List<PocoOLCUBR>>(_olcuBrDal.PagingList(skip, take));
        }

        public PocoOLCUBR EkleyadaGuncelle(PocoOLCUBR pModel)
        {
           
            return  _mapper.Map<MPOLCUBR,PocoOLCUBR>( _olcuBrDal.EkleyadaGuncelle(_mapper.Map<PocoOLCUBR, MPOLCUBR>(pModel)));
        }

       
    }
}
