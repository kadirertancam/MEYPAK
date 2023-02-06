using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.PersonelDal;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Interfaces.Personel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.PERSONEL
{
    public class PersonelAvansManager : BaseManager<PocoPERSONELAVANS, MPPERSONELAVANS>, IPersonelAvansServis
    {
        IPersonelAvansDal _personelAvansDal;
        IMapper _mapper;
        public PersonelAvansManager(IMapper mapper, IPersonelAvansDal repo, string includeEntities = null) : base(mapper, repo, includeEntities)
        {
            _personelAvansDal=repo;
            _mapper = mapper;
        }
    }
}
