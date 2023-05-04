using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.ARAC;
using MEYPAK.Entity.Models.DESTEKSERVİS;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Entity.PocoModels.DESTEKSERVIS;
using MEYPAK.Interfaces.Arac;
using MEYPAK.Interfaces.DestekServis;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.ARACControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ARACMUAYENERESIMController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAracMuayeneResimServis _destekServis;
        private MPAdoContext<MPARACMUAYENERESIM> _adodestekServis = new MPAdoContext<MPARACMUAYENERESIM>();
        public ARACMUAYENERESIMController(IMapper mapper, IAracMuayeneResimServis destekServis)
        {
            _mapper = mapper;
            _destekServis = destekServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult Liste()
        {
            try
            {
                var data = _destekServis.Listele();
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
                _adodestekServis.HepsiniGetir(query);
                return Ok(_adodestekServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult EkleyadaGuncelle(PocoARACMUAYENERESIM pModel)
        {
            try
            {
                var data = _destekServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Sil(List<PocoARACMUAYENERESIM> pModel)
        {
            try
            {
                var data = _destekServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Guncelle(PocoARACMUAYENERESIM pModel)
        {
            try
            {
                var data = _destekServis.Guncelle(pModel);
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
                bool succes = _destekServis.DeleteById(id);
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
