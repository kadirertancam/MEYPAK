using AutoMapper;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    [ApiController]
    [Route("[controller]")]
    public class STOKKASAController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStokKasaServis _stokKasaServis;

        public STOKKASAController(IMapper mapper, IStokKasaServis stokKasaServis)
        {
            _mapper = mapper;
            _stokKasaServis = stokKasaServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKASAListe()
        {
            try
            {
                var data = _stokKasaServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKASAEkleyadaGuncelle(PocoSTOKKASA pModel)
        {
            try
            {
                var data = _stokKasaServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKASASil(List<PocoSTOKKASA> pModel)
        {
            try
            {
                var data = _stokKasaServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKASAGuncelle(PocoSTOKKASA pModel)
        {
            try
            {
                var data = _stokKasaServis.Guncelle(pModel);
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
                bool succes = _stokKasaServis.DeleteById(id);
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
