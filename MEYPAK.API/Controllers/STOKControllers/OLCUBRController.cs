using AutoMapper;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    [ApiController]
    [Route("[controller]")]
    public class OLCUBRController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IOlcuBrServis _olcuBrServis;

        public OLCUBRController(IMapper mapper, IOlcuBrServis olcuBrServis)
        {
            _mapper = mapper;
            _olcuBrServis = olcuBrServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult OLCUBRListe()
        {
            try
            {
                var data = _olcuBrServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult OLCUBREkle(PocoOLCUBR pModel)
        {
            try
            {
                var data = _olcuBrServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult OLCUBRSil(List<PocoOLCUBR> pModel)
        {
            try
            {
                var data = _olcuBrServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult OLCUBRGuncelle(PocoOLCUBR pModel)
        {
            try
            {
                var data = _olcuBrServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
    }
}
