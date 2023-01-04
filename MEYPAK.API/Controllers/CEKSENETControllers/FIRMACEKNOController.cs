using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.CEKSENET;
using MEYPAK.Entity.PocoModels.CEKSENET;
using MEYPAK.Interfaces.CekSenet;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.CEKSENETControllers
{
    [ApiController]
    [Route("[controller]")]
    public class FIRMACEKNOController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFirmaCekNoServis _FCekNoServis;
        private MPAdoContext<MPFIRMACEKNO> _adobankaServis = new MPAdoContext<MPFIRMACEKNO>();
        public FIRMACEKNOController(IMapper mapper, IFirmaCekNoServis FCekNoServis)
        {
            _mapper = mapper;
            _FCekNoServis = FCekNoServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult Liste()
        {
            try
            {
                var data = _FCekNoServis.Listele();
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
        public IActionResult EkleyadaGuncelle([FromBody] PocoFIRMACEKNO pModel)
        {
            try
            {
                var data = _FCekNoServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Sil(List<PocoFIRMACEKNO> pModel)
        {
            try
            {
                var data = _FCekNoServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Guncelle(PocoFIRMACEKNO pModel)
        {
            try
            {
                var data = _FCekNoServis.Guncelle(pModel);
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
                bool succes = _FCekNoServis.DeleteById(id);
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
