using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.AracDal;
using MEYPAK.Entity.Models.ARAC;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Interfaces.Arac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.ARAC
{
    public class AracMuayeneResimManager : BaseManager<PocoARACMUAYENERESIM, MPARACMUAYENERESIM>, IAracMuayeneResimServis
    {
        public AracMuayeneResimManager(IMapper mapper, IAracMuayeneResimDal repo, string includeEntities = null) : base(mapper, repo, includeEntities)
        {
        }
    }
}
