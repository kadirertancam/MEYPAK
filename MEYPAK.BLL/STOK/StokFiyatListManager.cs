using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.STOK
{
    public class StokFiyatListManager : BaseManager<PocoSTOKFIYATLIST,MPSTOKFIYATLIST>,IStokFiyatListServis
    {
        IStokFiyatListDal _stokFiyatListDal;
        IMapper _mapper;
        public StokFiyatListManager(IMapper mapper,IStokFiyatListDal stokFiyatListDal) : base(mapper, stokFiyatListDal)
        {
            _stokFiyatListDal = stokFiyatListDal;
            _mapper= mapper;
        }

        public PocoSTOKFIYATLIST EkleyadaGuncelle(PocoSTOKFIYATLIST pModel)
        {
            
            return _mapper.Map<MPSTOKFIYATLIST, PocoSTOKFIYATLIST>(_stokFiyatListDal.EkleyadaGuncelle(_mapper.Map<PocoSTOKFIYATLIST, MPSTOKFIYATLIST>(pModel)));
        }

        public List<PocoStokFiyatList> PocoStokFiyatListesi()
        {
            return _stokFiyatListDal.PocoStokFiyatListesi();
        }
    }
}
