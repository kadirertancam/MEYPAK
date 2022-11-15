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
    public class ARACKASKORESIMController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAracKaskoResimServis _aracKaskoResimServis;
        private MPAdoContext<MPARACKASKORESIM> _adoaracKaskoResimServis = new MPAdoContext<MPARACKASKORESIM>();
        public ARACKASKORESIMController(IMapper mapper, IAracKaskoResimServis aracKaskoResimServis)
        {
            _mapper = mapper;
            _aracKaskoResimServis = aracKaskoResimServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult ARACKASKORESIMListe()
        {
            try
            {
                var data = _aracKaskoResimServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult ARACKASKORESIMListe2([FromQuery] string query)
        {
            try
            {
                _adoaracKaskoResimServis.HepsiniGetir(query);
                return Ok(_adoaracKaskoResimServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACKASKORESIMEkleyadaGuncelle(PocoARACKASKORESIM pModel)
        {
            try
            {
                var data = _aracKaskoResimServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACKASKORESIMSil(List<PocoARACKASKORESIM> pModel)
        {
            try
            {
                var data = _aracKaskoResimServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACKASKORESIMGuncelle(PocoARACKASKORESIM pModel)
        {
            try
            {
                var data = _aracKaskoResimServis.Guncelle(pModel);
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
                bool succes = _aracKaskoResimServis.DeleteById(id);
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
