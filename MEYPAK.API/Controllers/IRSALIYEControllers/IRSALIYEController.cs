using AutoMapper;
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
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult IRSALIYEEkle(PocoIRSALIYE pModel)
        {
            try
            {
                var data = _ırsaliyeServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
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
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
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
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }
    }
}
