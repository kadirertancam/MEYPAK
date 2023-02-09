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
    public class PersonelIzinManager : BaseManager<PocoPERSONELIZIN, MPPERSONELIZIN>, IPersonelIzinServis
    {
        IPersonelIzinDal _personelGorevDal;
        IMapper _mapper;
        public PersonelIzinManager(IMapper mapper, IPersonelIzinDal repo, string includeEntities = null) : base(mapper, repo, includeEntities)
        {
            _personelGorevDal = repo;
            _mapper= mapper;
        }
    }
}
