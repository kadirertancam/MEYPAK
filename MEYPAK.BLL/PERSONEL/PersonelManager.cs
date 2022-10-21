using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.PersonelDal;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Interfaces;
using MEYPAK.Interfaces.Personel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.PERSONEL
{
    public class PersonelManager :BaseManager<PocoPERSONEL,MPPERSONEL> ,IPersonelServis
    {
        IPersonelDal _personelDal;
        IMapper _mapper;

        public PersonelManager(IMapper mapper ,IPersonelDal personelDal) : base(mapper,personelDal)
        {
            _personelDal = personelDal;
            _mapper = mapper;
        }


        public PocoPERSONEL EkleyadaGuncelle(PocoPERSONEL pModel)
        {
            return _mapper.Map<MPPERSONEL,PocoPERSONEL>(_personelDal.EkleyadaGuncelle(_mapper.Map<PocoPERSONEL,MPPERSONEL>(pModel)));
        }


    }
}
