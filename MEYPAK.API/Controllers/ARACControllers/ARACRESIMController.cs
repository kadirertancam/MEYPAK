using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.ARAC;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Interfaces.Arac;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.ARACControllers
{
    [ApiController]
    [Route("[controller]")]
    public class ARACRESIMController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAracResimServis _aracResimServis;
        private MPAdoContext<MPARACRESIM> _adoaracResimServis = new MPAdoContext<MPARACRESIM>();
        public ARACRESIMController(IMapper mapper, IAracResimServis aracResimServis)
        {
            _mapper = mapper;
            _aracResimServis = aracResimServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult ARACRESIMListe()
        {
            try
            {
                var data = _aracResimServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult ARACRESIMListe2([FromQuery] string query)
        {
            try
            {
                _adoaracResimServis.HepsiniGetir(query);
                return Ok(_adoaracResimServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACRESIMEkleyadaGuncelle(PocoARACRESIM pModel)
        {
            try
            {
                var data = _aracResimServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACRESIMSil(List<PocoARACRESIM> pModel)
        {
            try
            {
                var data = _aracResimServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACRESIMGuncelle(PocoARACRESIM pModel)
        {
            try
            {
                var data = _aracResimServis.Guncelle(pModel);
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
                bool succes = _aracResimServis.DeleteById(id);
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
