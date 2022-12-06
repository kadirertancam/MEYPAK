using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.PARAMETRE;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Interfaces.Parametre;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.PARAMETREControllers
{
    public class SeriHarHarController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISeriHarServis MPSeriHarServis;
        private MPAdoContext<MPSERIHAR> _adoMPSeriHarServis;
        public SeriHarHarController(IMapper mapper, ISeriHarServis cariServis)
        {
            _mapper = mapper;
            MPSeriHarServis = cariServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult MPSeriHarListe()
        {
            try
            {
                var data = MPSeriHarServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult MPSeriHarListe2([FromQuery] string query)
        {
            try
            {
                _adoMPSeriHarServis.HepsiniGetir(query);
                return Ok(_adoMPSeriHarServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult MPSeriHarEkleyadaGuncelle([FromBody] PocoSERIHAR pModel)
        {
            try
            {
                var data = MPSeriHarServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult MPSeriHarSil(List<PocoSERIHAR> pModel)
        {
            try
            {
                var data = MPSeriHarServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult MPSeriHarGuncelle(PocoSERIHAR pModel)
        {
            try
            {
                var data = MPSeriHarServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
    }
}
