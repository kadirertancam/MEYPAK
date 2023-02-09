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
    public class PERSONELDEPARTMANController : Controller
    {
        private readonly IPersonelDepartmanServis _personelDepartmanServis;
        private readonly IMapper _mapper;
        private MPAdoContext<MPPERSONELDEPARTMAN> _adopersonelDepartmanServis = new MPAdoContext<MPPERSONELDEPARTMAN>();

        public PERSONELDEPARTMANController(IPersonelDepartmanServis personelDepartmanServis, IMapper mapper)
        {
            _personelDepartmanServis = personelDepartmanServis;
            _mapper = mapper;
            
        }


        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELDEPARTMANListe()
        {
            try
            {
                var data = _personelDepartmanServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELDEPARTMANListe2([FromQuery] string query)
        {
            try
            {
                _adopersonelDepartmanServis.HepsiniGetir(query);
                return Ok(_adopersonelDepartmanServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELDEPARTMANEkleyadaGuncelle(PocoPERSONELDEPARTMAN pModel)
        {
            try
            {
                var data = _personelDepartmanServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELDEPARTMANSil(List<PocoPERSONELDEPARTMAN> pModel)
        {
            try
            {
                var data = _personelDepartmanServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELDEPARTMANGuncelle(PocoPERSONELDEPARTMAN pModel)
        {
            try
            {
                var data = _personelDepartmanServis.Guncelle(pModel);
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
                bool succes = _personelDepartmanServis.DeleteById(id);
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
