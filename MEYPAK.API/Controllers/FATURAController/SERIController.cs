using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Interfaces.Parametre;
using Microsoft.AspNetCore.Mvc;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Entity.Models.PARAMETRE;

namespace MEYPAK.API.Controllers.SERIController
{
    [ApiController]
    [Route("[controller]")]
    public class SERIController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISeriServis _SERIServis;
        private MPAdoContext<MPSERI> _adoSERIServis = new MPAdoContext<MPSERI>();
        public SERIController(IMapper mapper, ISeriServis SERIServis)
        {
            _mapper = mapper;
            _SERIServis = SERIServis;
        }
        
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult SERIListe()
        {
            try
            {
                var data = _SERIServis.Listele();
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
        public IActionResult SERIEKleyadaGuncelle(PocoSERI pModel)
        {
            try
            {
                var data = _SERIServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SERISil(List<PocoSERI> pModel)
        {
            try
            {
                var data = _SERIServis.Sil(pModel);
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
                var data = _SERIServis.Guncelle(pModel);
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
                bool succes = _SERIServis.DeleteById(id);
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
