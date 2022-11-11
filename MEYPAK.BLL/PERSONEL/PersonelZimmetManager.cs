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
    public class PersonelZimmetManager : BaseManager<PocoPERSONELZIMMET, MPPERSONELZIMMET>, IPersonelZimmetServis
    {
        IPersonelZimmetDal _personelZimmetDal;
        IMapper _mapper;

        public PersonelZimmetManager(IMapper mapper, IPersonelZimmetDal repo) : base(mapper, repo)
        {
            _personelZimmetDal = repo;
            _mapper=mapper;

        }

        public PocoPERSONELZIMMET EkleyadaGuncelle(PocoPERSONELZIMMET pModel)
        {
            return _mapper.Map<MPPERSONELZIMMET, PocoPERSONELZIMMET>(_personelZimmetDal.EkleyadaGuncelle(_mapper.Map<PocoPERSONELZIMMET, MPPERSONELZIMMET>(pModel)));
        }
    }
}
