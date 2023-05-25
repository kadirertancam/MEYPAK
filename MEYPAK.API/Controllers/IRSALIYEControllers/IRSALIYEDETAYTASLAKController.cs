using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Interfaces.IRSALIYE;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.IRSALIYEControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class IRSALIYEDETAYTASLAKController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IIrsaliyeDetayTaslakServis _faturaServis;
        private MPAdoContext<MPIRSALIYEDETAYTASLAK> _adoFaturaServis = new MPAdoContext<MPIRSALIYEDETAYTASLAK>();
        public IRSALIYEDETAYTASLAKController(IMapper mapper, IIrsaliyeDetayTaslakServis faturaServis)
        {
            _mapper = mapper;
            _faturaServis = faturaServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult Liste()
        {
            try
            {
                var data = _faturaServis.Listele();
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
                _adoFaturaServis.HepsiniGetir(query);
                return Ok(_adoFaturaServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult EKleyadaGuncelle(PocoIRSALIYEDETAYTASLAK pModel)
        {
            try
            {
                var data = _faturaServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Sil(List<PocoIRSALIYEDETAYTASLAK> pModel)
        {
            try
            {
                var data = _faturaServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Guncelle(PocoIRSALIYEDETAYTASLAK pModel)
        {
            try
            {
                var data = _faturaServis.Guncelle(pModel);
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
                bool succes = _faturaServis.DeleteById(id);
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
