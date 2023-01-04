using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.BANKA;
using MEYPAK.Entity.Models.CEKSENET;
using MEYPAK.Entity.PocoModels.BANKA;
using MEYPAK.Entity.PocoModels.CEKSENET;
using MEYPAK.Interfaces.Banka;
using MEYPAK.Interfaces.CekSenet;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.CEKSENETControllers
{
    [ApiController]
    [Route("[controller]")]
    public class FIRMACEKHARController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFirmaCekHarServis _FCekHarServis;
        private MPAdoContext<MPFIRMACEKHAR> _adobankaServis = new MPAdoContext<MPFIRMACEKHAR>();
        public FIRMACEKHARController(IMapper mapper, IFirmaCekHarServis FCekHarServis)
        {
            _mapper = mapper;
            _FCekHarServis = FCekHarServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult Liste()
        {
            try
            {
                var data = _FCekHarServis.Listele();
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
        public IActionResult EkleyadaGuncelle([FromBody] PocoFIRMACEKHAR pModel)
        {
            try
            {
                var data = _FCekHarServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Sil(List<PocoFIRMACEKHAR> pModel)
        {
            try
            {
                var data = _FCekHarServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Guncelle(PocoFIRMACEKHAR pModel)
        {
            try
            {
                var data = _FCekHarServis.Guncelle(pModel);
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
                bool succes = _FCekHarServis.DeleteById(id);
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
