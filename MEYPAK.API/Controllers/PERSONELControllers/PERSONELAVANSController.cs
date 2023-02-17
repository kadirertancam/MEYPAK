using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Interfaces.Personel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.PERSONELControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class PERSONELAVANSController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPersonelAvansServis _personelIzinServis;
        private MPAdoContext<PocoPERSONELAVANS> _adobankaServis = new MPAdoContext<PocoPERSONELAVANS>();
        public PERSONELAVANSController(IMapper mapper, IPersonelAvansServis bankaServis)
        {
            _mapper = mapper;
            _personelIzinServis = bankaServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult Liste()
        {
            try
            {
                var data = _personelIzinServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult Liste2([FromQuery] string query)
        {
            try
            {
                _adobankaServis.HepsiniGetir(query);
                return Ok(_adobankaServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult EkleyadaGuncelle([FromQuery] PocoPERSONELAVANS pModel)
        {
            try
            {
                var data = _personelIzinServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Sil(List<PocoPERSONELAVANS> pModel)
        {
            try
            {
                var data = _personelIzinServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Guncelle(PocoPERSONELAVANS pModel)
        {
            try
            {
                var data = _personelIzinServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DeleteById([FromQuery] int id)
        {
            try
            {
                bool succes = _personelIzinServis.DeleteById(id);
                if (succes)
                    return Ok(id + " Başarıyla Silindi");
                else
                    return Ok(id + " Silinemedi.");
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
    }
}
