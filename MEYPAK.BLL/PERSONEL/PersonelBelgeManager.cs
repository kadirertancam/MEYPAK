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
    public class PersonelBelgeManager : BaseManager<PocoPERSONELBELGE, MPPERSONELBELGE>, IPersonelBelgeServis
    {
        IPersonelBelgeDal personelBelge;
        public PersonelBelgeManager(IMapper mapper, IPersonelBelgeDal repo, string includeEntities = null) : base(mapper, repo, includeEntities)
        {
            personelBelge = repo;
        }
    }
}
