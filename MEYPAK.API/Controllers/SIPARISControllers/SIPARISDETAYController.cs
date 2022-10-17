using AutoMapper;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Interfaces.Siparis;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.SIPARISControllers
{
    [ApiController]
    [Route("[controller]")]
    public class SIPARISDETAYController : Controller
    {
        private readonly ISiparisDetayServis _siparisDetayServis;
        private readonly IMapper _mapper;

        public SIPARISDETAYController(ISiparisDetayServis siparisDetayServis, IMapper mapper)
        {
            _siparisDetayServis = siparisDetayServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISDETAYListe()
        {
            try
            {
                var data = _siparisDetayServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISDETAYEkle(PocoSIPARISDETAY pModel)
        {
            try
            {
                var data = _siparisDetayServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISDETAYSil(List<PocoSIPARISDETAY> pModel)
        {
            try
            {
                var data = _siparisDetayServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISDETAYGuncelle(PocoSIPARISDETAY pModel)
        {
            try
            {
                var data = _siparisDetayServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
    }
}
