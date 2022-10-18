using AutoMapper;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Hizmet;
using MEYPAK.Interfaces.Siparis;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.SIPARISControllers
{
    [ApiController]
    [Route("[controller]")]
    public class SIPARISController : Controller
    {
        private readonly ISiparisServis _siparisServis;
        private readonly IMapper _mapper;

        public SIPARISController(ISiparisServis siparisServis, IMapper mapper)
        {
            _siparisServis = siparisServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISListe()
        {
            try
            {
                var data = _siparisServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISEkle(PocoSIPARIS pModel)
        {
            try
            {
                var data = _siparisServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISSil(List<PocoSIPARIS> pModel)
        {
            try
            {
                var data = _siparisServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISGuncelle(PocoSIPARIS pModel)
        {
            try
            {
                var data = _siparisServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
    }
}
