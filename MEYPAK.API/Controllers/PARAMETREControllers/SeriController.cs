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
    public class SeriController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISeriServis SERIServis;
        private MPAdoContext<MPSERI> _adoSERIServis;
        public SeriController(IMapper mapper, ISeriServis cariServis)
        {
            _mapper = mapper;
            SERIServis = cariServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult SERIListe()
        {
            try
            {
                var data = SERIServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult SERIListe2([FromQuery] string query)
        {
            try
            {
                _adoSERIServis.HepsiniGetir(query);
                return Ok(_adoSERIServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SERIEkleyadaGuncelle([FromBody]PocoSERI pModel)
        {
            try
            {
                var data = SERIServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SERISil(List<PocoSERI> pModel)
        {
            try
            {
                var data = SERIServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SERIGuncelle(PocoSERI pModel)
        {
            try
            {
                var data = SERIServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

    }
}
