using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.IRSALIYE;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.IRSALIYEControllers
{
    [ApiController]
    [Route("[controller]")]
    public class IRSALIYEController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IIrsaliyeServis _ırsaliyeServis;
        private MPAdoContext<MPIRSALIYE> _adoırsaliyeServis = new MPAdoContext<MPIRSALIYE>();
        public IRSALIYEController(IMapper mapper, IIrsaliyeServis irsaliyeServis)
        {
            _mapper = mapper;
            _ırsaliyeServis = irsaliyeServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult IRSALIYEListe()
        {
            try
            {
                var data = _ırsaliyeServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult IRSALIYEListe2([FromQuery] string query)
        {
            try
            {
                _adoırsaliyeServis.HepsiniGetir(query);
                return Ok(_adoırsaliyeServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult IRSALIYEEkleyadaGuncelle(PocoIRSALIYE pModel)
        {
            try
            {
                var data = _ırsaliyeServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult IRSALIYESil(List<PocoIRSALIYE> pModel)
        {
            try
            {
                var data = _ırsaliyeServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult IRSALIYEGuncelle(PocoIRSALIYE pModel)
        {
            try
            {
                var data = _ırsaliyeServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DeleteById([FromBody] int id)
        {
            try
            {
                bool succes = _ırsaliyeServis.DeleteById(id);
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
