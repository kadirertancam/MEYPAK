using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Interfaces.Cari;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.CARIControllers
{
    public class CARIYETKILIController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICariYetkiliServis _cariYetkiliServis;
        private MPAdoContext<MPCARIYETKILI> _adocariServis = new MPAdoContext<MPCARIYETKILI>();

        public CARIYETKILIController(IMapper mapper, ICariYetkiliServis cariYetkiliServis)
        {
            _mapper = mapper;
            _cariYetkiliServis = cariYetkiliServis;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
