using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Depo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.DEPO
{
    public class StokMalKabulListManager : BaseManager<PocoSTOKMALKABULLIST,MPSTOKMALKABULLIST>, IStokMalKabulListServis
    {
        IStokMalKKabulListDal _stokMalKKabulListDal;
        IMapper _mapper;
        public StokMalKabulListManager(IMapper mapper,IStokMalKKabulListDal stokMalKKabulListDal) : base(mapper,stokMalKKabulListDal)
        {
            _stokMalKKabulListDal = stokMalKKabulListDal;
            _mapper=mapper;
        }

        public PocoSTOKMALKABULLIST EkleyadaGuncelle(PocoSTOKMALKABULLIST pModel)
        {
            return _mapper.Map<MPSTOKMALKABULLIST,PocoSTOKMALKABULLIST>( _stokMalKKabulListDal.EkleyadaGuncelle(_mapper.Map<PocoSTOKMALKABULLIST,MPSTOKMALKABULLIST>(pModel)));
        }

    
    }
}
