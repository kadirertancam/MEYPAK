using AutoMapper;
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
    public class PersonelGorevManager : BaseManager<PocoPERSONELGOREV, MPPERSONELGOREV>, IPersonelGorevServis
    {
        IPersonelGorevDal _personelGorevDal;
        IMapper _mapper;

        public PersonelGorevManager(IMapper mapper, IPersonelGorevDal personelGorevDal) : base(mapper, personelGorevDal)
        {
            _personelGorevDal = personelGorevDal;
            _mapper = mapper;
        }


        public PocoPERSONELGOREV EkleyadaGuncelle(PocoPERSONELGOREV pModel)
        {
            return _mapper.Map<MPPERSONELGOREV, PocoPERSONELGOREV>(_personelGorevDal.EkleyadaGuncelle(_mapper.Map<PocoPERSONELGOREV, MPPERSONELGOREV>(pModel)));
        }
    }
}
