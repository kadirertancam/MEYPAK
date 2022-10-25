using AutoMapper;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Interfaces.IRSALIYE;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.IRSALIYEControllers
{
    [ApiController]
    [Route("[controller]")]
    public class IRSALIYEDETAYController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IIrsaliyeDetayServis _ırsaliyeDetayServis;

        public IRSALIYEDETAYController(IMapper mapper, IIrsaliyeDetayServis irsaliyeDetayServis)
        {
            _mapper = mapper;
            _ırsaliyeDetayServis = irsaliyeDetayServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult IRSALIYEDETAYListe()
        {
            try
            {
                var data = _ırsaliyeDetayServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult IRSALIYEDETAYEkleyadaGuncelle(PocoIRSALIYEDETAY pModel)
        {
            try
            {
                var data = _ırsaliyeDetayServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult IRSALIYEDETAYSil(List<PocoIRSALIYEDETAY> pModel)
        {
            try
            {
                var data = _ırsaliyeDetayServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult IRSALIYEDETAYGuncelle(PocoIRSALIYEDETAY pModel)
        {
            try
            {
                var data = _ırsaliyeDetayServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
    }
}
