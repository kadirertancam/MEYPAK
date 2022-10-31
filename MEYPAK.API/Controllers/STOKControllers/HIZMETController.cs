using AutoMapper;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Hizmet;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    [ApiController]
    [Route("[controller]")]
    public class HIZMETController : Controller
    {
        private readonly IHizmetServis _hizmetServis; 
        private readonly IMapper _mapper;

        public HIZMETController(IHizmetServis hizmetServis, IMapper mapper)
        {
            _hizmetServis = hizmetServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult HIZMETListe()
        {
            try
            {
                var data = _hizmetServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult HIZMETEkleyadaGuncelle(PocoHIZMET pModel)
        {
            try
            {
                var data = _hizmetServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult HIZMETSil(List<PocoHIZMET> pModel)
        {
            try
            {
                var data = _hizmetServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex )
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult HIZMETGuncelle(PocoHIZMET pModel)
        {
            try
            {
                var data = _hizmetServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex )
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpDelete]
        [Route("/[controller]/[action]")]
        public IActionResult DeleteById([FromBody] int id)
        {
            try
            {
                bool succes = _hizmetServis.DeleteById(id);
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
