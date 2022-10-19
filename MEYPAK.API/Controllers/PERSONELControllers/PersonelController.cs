using AutoMapper;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Interfaces.Personel;
using MEYPAK.Interfaces.Siparis;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.PERSONELControllers
{
    [ApiController]
    [Route("[controller]")]
    public class PERSONELController : Controller
    {
        private readonly IPersonelServis _personelServis;
        private readonly IMapper _mapper;

        public PERSONELController(IPersonelServis personelServis, IMapper mapper)
        {
            _personelServis = personelServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELListe()
        {
            try
            {
                var data = _personelServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELEkle(PocoPERSONEL pModel)
        {
            try
            {
                var data = _personelServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELSil(List<PocoPERSONEL> pModel)
        {
            try
            {
                var data = _personelServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELGuncelle(PocoPERSONEL pModel)
        {
            try
            {
                var data = _personelServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }
    }
}
