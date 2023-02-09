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
    public class SeriHarController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISeriHarServis SeriHarServis;
        private MPAdoContext<MPSERIHAR> _adoSeriHarServis;
        public SeriHarController(IMapper mapper, ISeriHarServis cariServis)
        {
            _mapper = mapper;
            SeriHarServis = cariServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult SeriHarListe()
        {
            try
            {
                var data = SeriHarServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult SeriHarListe2([FromQuery] string query)
        {
            try
            {
                _adoSeriHarServis.HepsiniGetir(query);
                return Ok(_adoSeriHarServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SeriHarEkleyadaGuncelle([FromBody] PocoSERIHAR pModel)
        {
            try
            {
                var data = SeriHarServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SeriHarSil(List<PocoSERIHAR> pModel)
        {
            try
            {
                var data = SeriHarServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SeriHarGuncelle(PocoSERIHAR pModel)
        {
            try
            {
                var data = SeriHarServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
    }
}
