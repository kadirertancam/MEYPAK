using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.DepoDal;
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
    public class StokSevkiyatListManager : BaseManager<PocoSTOKSEVKIYATLIST,MPSTOKSEVKİYATLİST>, IStokSevkiyatListServis
    {
        IStokSevkiyatListDal _stokSevkiyatListDal;
        IMapper _mapper;
        public StokSevkiyatListManager(IMapper mapper,IStokSevkiyatListDal stokSevkiyatListDal) : base(mapper,stokSevkiyatListDal)
        {
            _stokSevkiyatListDal=stokSevkiyatListDal;
            _mapper=mapper;
            
        }

        public Durum EkleyadaGuncelle(PocoSTOKSEVKIYATLIST pModel)
        {
            return _stokSevkiyatListDal.EkleyadaGuncelle(_mapper.Map<PocoSTOKSEVKIYATLIST,MPSTOKSEVKİYATLİST>(pModel));
            
        }

        public void OnYukle()
        {
            _stokSevkiyatListDal.OnYukle();
        }
    }
}
