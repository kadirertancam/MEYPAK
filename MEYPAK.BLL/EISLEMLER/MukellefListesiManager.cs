using AutoMapper;
using MEYPAK.DAL.Abstract;
using MEYPAK.DAL.Abstract.EIslemlerDal;
using MEYPAK.Entity.Models.EISLEMLER;
using MEYPAK.Entity.PocoModels.EISLEMLER;
using MEYPAK.Interfaces.EIslemler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYPAK.BLL.EISLEMLER
{
    public class MukellefListesiManager : BaseManager<PocoMUKELLEFLISTESI, MPMUKELLEFLISTESI>,IMukellefListesiServis
    {
        IMapper mapper;
        IMukellefListDal IMukellefListesiServis;
        public MukellefListesiManager(IMapper mapper, IMukellefListDal repo) : base(mapper, repo)
        {
            this.mapper = mapper;
            IMukellefListesiServis = repo;
        }
    }
}
