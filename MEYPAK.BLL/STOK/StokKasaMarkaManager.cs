using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.KasaDal;
using MEYPAK.DAL.Abstract.StokDal;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.STOK
{
    public class StokKasaMarkaManager : BaseManager<PocoSTOKKASAMARKA, MPSTOKKASAMARKA>,IStokKasaMarkaServis
    {
        IMapper mapper;
        IStokKasaMarkaDal _stokKasaMarkaDal;
        public StokKasaMarkaManager(IMapper mapper, IStokKasaMarkaDal repo ) : base(mapper, repo )
        {
            _stokKasaMarkaDal = repo;
            this.mapper=mapper;
        }
        public PocoSTOKKASAMARKA EkleyadaGuncelle(PocoSTOKKASAMARKA pModel)
        {
            return mapper.Map<MPSTOKKASAMARKA, PocoSTOKKASAMARKA>(_stokKasaMarkaDal.EkleyadaGuncelle(mapper.Map<PocoSTOKKASAMARKA, MPSTOKKASAMARKA>(pModel)));
        }
    }
}
