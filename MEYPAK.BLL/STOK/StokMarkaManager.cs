using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MEYPAK.DAL;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Stok;

namespace MEYPAK.BLL.STOK
{
    public class StokMarkaManager :BaseManager<PocoSTOKMARKA,MPSTOKMARKA>, IStokMarkaServis
    {
        IStokMarkaDal _markaDal;
        IMapper _mapper;

        public StokMarkaManager(IMapper mapper,IStokMarkaDal stokMarkaDal) : base(mapper,stokMarkaDal)
        {
            _markaDal = stokMarkaDal;   
            _mapper = mapper;
        }

        public List<PocoSTOKMARKA> PagingList(int skip, int take)
        {
            return _mapper.Map<List<PocoSTOKMARKA>>(_markaDal.PagingList(skip, take));
        }
        public PocoSTOKMARKA EkleyadaGuncelle(PocoSTOKMARKA pModel)
        {
            return _mapper.Map<MPSTOKMARKA,PocoSTOKMARKA>(_markaDal.EkleyadaGuncelle(_mapper.Map<PocoSTOKMARKA,MPSTOKMARKA>(pModel)));
        }

        
    }
}
