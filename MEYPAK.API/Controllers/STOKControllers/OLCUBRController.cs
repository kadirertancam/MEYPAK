using AutoMapper;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    [ApiController]
    [Route("[controller]")]
    public class OLCUBRController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IOlcuBrServis _olcuBrServis;

        public OLCUBRController(IMapper mapper, IOlcuBrServis olcuBrServis)
        {
            _mapper = mapper;
            _olcuBrServis = olcuBrServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult OLCUBRListe()
        {
            try
            {
                var data = _olcuBrServis.Listele();
                return Ok(data);
            }
            catch (Exception ex )
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult OLCUBREkleyadaGuncelle(PocoOLCUBR pModel)
        {
            try
            {
                var data = _olcuBrServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult OLCUBRSil(List<PocoOLCUBR> pModel)
        {
            try
            {
                var data = _olcuBrServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult OLCUBRGuncelle(PocoOLCUBR pModel)
        {
            try
            {
                var data = _olcuBrServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex )
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
                bool succes = _olcuBrServis.DeleteById(id);
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
