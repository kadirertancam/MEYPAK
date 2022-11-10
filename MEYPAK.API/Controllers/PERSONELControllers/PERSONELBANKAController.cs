using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Interfaces.Personel;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.PERSONELControllers
{
    [ApiController]
    [Route("[controller]")]
    public class PERSONELBANKAController : Controller
    {
        private readonly IPersonelBankaServis _personelBankaServis;
        private readonly IMapper _mapper;
        private MPAdoContext<MPPERSONELBANKA> _adopersonelBankaServis = new MPAdoContext<MPPERSONELBANKA>();

        public PERSONELBANKAController(IPersonelBankaServis personelBankaServis, IMapper mapper)
        {
            _personelBankaServis = personelBankaServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELBANKAListe()
        {
            try
            {
                var data = _personelBankaServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELBANKAListe2([FromQuery] string query)
        {
            try
            {
                _adopersonelBankaServis.HepsiniGetir(query);
                return Ok(_adopersonelBankaServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELBANKAEkleyadaGuncelle(PocoPERSONELBANKA pModel)
        {
            try
            {
                var data = _personelBankaServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELBANKASil(List<PocoPERSONELBANKA> pModel)
        {
            try
            {
                var data = _personelBankaServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELBANKAGuncelle(PocoPERSONELBANKA pModel)
        {
            try
            {
                var data = _personelBankaServis.Guncelle(pModel);
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
                bool succes = _personelBankaServis.DeleteById(id);
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
