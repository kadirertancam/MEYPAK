using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.PARAMETRE;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Interfaces.Parametre;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.PARAMETREControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class SeriYetkiController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISeriYetkiServis SeriYetkiServis;
        private MPAdoContext<MPSERIYETKI> _adoSeriYetkiServis;
        public SeriYetkiController(IMapper mapper, ISeriYetkiServis cariServis)
        {
            _mapper = mapper;
            SeriYetkiServis = cariServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult SeriYetkiListe()
        {
            try
            {
                var data = SeriYetkiServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult SeriYetkiListe2([FromQuery] string query)
        {
            try
            {
                _adoSeriYetkiServis.HepsiniGetir(query);
                return Ok(_adoSeriYetkiServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SeriYetkiEkleyadaGuncelle([FromBody] PocoSERIYETKI pModel)
        {
            try
            {
                var data = SeriYetkiServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SeriYetkiSil(List<PocoSERIYETKI> pModel)
        {
            try
            {
                var data = SeriYetkiServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SeriYetkiGuncelle(PocoSERIYETKI pModel)
        {
            try
            {
                var data = SeriYetkiServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
    }
}
