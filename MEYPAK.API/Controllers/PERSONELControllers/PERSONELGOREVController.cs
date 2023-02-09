using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Interfaces.Personel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.PERSONELControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class PERSONELGOREVController : Controller
    {
        private readonly IPersonelGorevServis _personelGorevServis;
        private readonly IMapper _mapper;
        private MPAdoContext<MPPERSONELGOREV> _adopersonelGorevServis = new MPAdoContext<MPPERSONELGOREV>();

        public PERSONELGOREVController(IPersonelGorevServis personelGorevServis, IMapper mapper)
        {
            _personelGorevServis = personelGorevServis;
            _mapper = mapper;
           
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELGOREVListe()
        {
            try
            {
                var data = _personelGorevServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELGOREVListe2([FromQuery] string query)
        {
            try
            {
                _adopersonelGorevServis.HepsiniGetir(query);
                return Ok(_adopersonelGorevServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELGOREVEkleyadaGuncelle(PocoPERSONELGOREV pModel)
        {
            try
            {
                var data = _personelGorevServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELGOREVSil(List<PocoPERSONELGOREV> pModel)
        {
            try
            {
                var data = _personelGorevServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELGOREVGuncelle(PocoPERSONELGOREV pModel)
        {
            try
            {
                var data = _personelGorevServis.Guncelle(pModel);
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
                bool succes = _personelGorevServis.DeleteById(id);
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
