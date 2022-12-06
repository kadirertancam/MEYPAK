using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.PARAMETRE;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Interfaces.Parametre;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.PARAMETREControllers
{
    public class SeriController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISeriServis MPSERIServis;
        private MPAdoContext<MPSERI> _adoMPSERIServis;
        public SeriController(IMapper mapper, ISeriServis cariServis)
        {
            _mapper = mapper;
            MPSERIServis = cariServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult MPSERIListe()
        {
            try
            {
                var data = MPSERIServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult MPSERIListe2([FromQuery] string query)
        {
            try
            {
                _adoMPSERIServis.HepsiniGetir(query);
                return Ok(_adoMPSERIServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult MPSERIEkleyadaGuncelle([FromBody]PocoSERI pModel)
        {
            try
            {
                var data = MPSERIServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult MPSERISil(List<PocoSERI> pModel)
        {
            try
            {
                var data = MPSERIServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult MPSERIGuncelle(PocoSERI pModel)
        {
            try
            {
                var data = MPSERIServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

    }
}
