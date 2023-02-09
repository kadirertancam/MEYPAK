using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.ARAC;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Interfaces.Arac;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.ARACControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ARACRUHSATRESIMController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAracRuhsatResimServis _aracRuhsatResimServis;
        private MPAdoContext<MPARACRUHSATRESIM> _adoaracRuhsatResimServis = new MPAdoContext<MPARACRUHSATRESIM>();
        public ARACRUHSATRESIMController(IMapper mapper, IAracRuhsatResimServis aracRuhsatResimServis)
        {
            _mapper = mapper;
            _aracRuhsatResimServis = aracRuhsatResimServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult ARACRUHSATRESIMListe()
        {
            try
            {
                var data = _aracRuhsatResimServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult ARACRUHSATRESIMListe2([FromQuery] string query)
        {
            try
            {
                _adoaracRuhsatResimServis.HepsiniGetir(query);
                return Ok(_adoaracRuhsatResimServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACRUHSATRESIMEkleyadaGuncelle(PocoARACRUHSATRESIM pModel)
        {
            try
            {
                var data = _aracRuhsatResimServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACRUHSATRESIMSil(List<PocoARACRUHSATRESIM> pModel)
        {
            try
            {
                var data = _aracRuhsatResimServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACRUHSATRESIMGuncelle(PocoARACRUHSATRESIM pModel)
        {
            try
            {
                var data = _aracRuhsatResimServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpDelete]
        [Route("/[controller]/[action]")]
        public IActionResult DeleteById([FromQuery] int id)
        {
            try
            {
                bool succes = _aracRuhsatResimServis.DeleteById(id);
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
