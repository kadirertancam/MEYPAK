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
    public class PersonelDepartmanManager: BaseManager<PocoPERSONELDEPARTMAN, MPPERSONELDEPARTMAN>, IPersonelDepartmanServis
    {
        IPersonelDepartmanDal _personelDepartmanDal;
        IMapper _mapper;

        public PersonelDepartmanManager(IMapper mapper, IPersonelDepartmanDal personelDepartmanDal) : base(mapper, personelDepartmanDal)
        {
            _personelDepartmanDal = personelDepartmanDal;
            _mapper = mapper;
        }


        public PocoPERSONELDEPARTMAN EkleyadaGuncelle(PocoPERSONELDEPARTMAN pModel)
        {
            return _mapper.Map<MPPERSONELDEPARTMAN, PocoPERSONELDEPARTMAN>(_personelDepartmanDal.EkleyadaGuncelle(_mapper.Map<PocoPERSONELDEPARTMAN, MPPERSONELDEPARTMAN>(pModel)));
        }
    }
}
