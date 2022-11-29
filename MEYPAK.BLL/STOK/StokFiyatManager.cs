using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.KasaDal;
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
    public class StokFiyatManager : BaseManager<PocoSTOKFIYAT, MPSTOKFIYAT>, IStokFiyatServis
    {
        IStokFiyatDal _stokFiyatDal;
        IMapper _mapper;

        public StokFiyatManager(IMapper mapper, IStokFiyatDal stokFiyatDal) : base(mapper, stokFiyatDal)
        {
            _stokFiyatDal = stokFiyatDal;
            _mapper = mapper;
        }

        public List<PocoSTOKFIYAT> PagingList(int skip, int take)
        {
            return _mapper.Map<List<PocoSTOKFIYAT>>(_stokFiyatDal.PagingList(skip, take));
        }

        public PocoSTOKFIYAT EkleyadaGuncelle(PocoSTOKFIYAT pModel)
        {
            return _mapper.Map<MPSTOKFIYAT, PocoSTOKFIYAT>(_stokFiyatDal.EkleyadaGuncelle(_mapper.Map<PocoSTOKFIYAT, MPSTOKFIYAT>(pModel)));
        }

    }  
    }

