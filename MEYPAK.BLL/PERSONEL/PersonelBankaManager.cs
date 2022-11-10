using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.PersonelDal;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Entity.PocoModels.PERSONEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.PERSONEL
{
    public class PersonelBankaManager : BaseManager<PocoPERSONELBANKA, MPPERSONELBANKA>
    {
        IPersonelBankaDal _personelbankaDal;
        IMapper _mapper;
        public PersonelBankaManager(IMapper mapper, IPersonelBankaDal personelbankadal) : base(mapper, personelbankadal)
        {
            _mapper = mapper;
            _personelbankaDal = personelbankadal;
        }


        public PocoPERSONELBANKA EkleyadaGuncelle(PocoPERSONELBANKA pModel)
        {
            return _mapper.Map<MPPERSONELBANKA, PocoPERSONELBANKA>(_personelbankaDal.EkleyadaGuncelle(_mapper.Map<PocoPERSONELBANKA, MPPERSONELBANKA>(pModel)));
        }

    }
}
