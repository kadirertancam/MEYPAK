using AutoMapper;
using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.DEPOControllers
{
    [ApiController]
    [Route("[controller]")]
    public class DEPOEMIRController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IDepoEmirServis _depoEmirServis;

        public DEPOEMIRController(IMapper mapper, IDepoEmirServis depoEmirServis)
        {
            _mapper = mapper;
            _depoEmirServis = depoEmirServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOEMIRListe()
        {
            try
            {
                var data = _depoEmirServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOEMIREkle(PocoDEPOEMIR pModel)
        {
            try
            {
                var data = _depoEmirServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOEMIRSil(List<PocoDEPOEMIR> pModel)
        {
            try
            {
                var data = _depoEmirServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOEMIRGuncelle(PocoDEPOEMIR pModel)
        {
            try
            {
                var data = _depoEmirServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
    }
}
