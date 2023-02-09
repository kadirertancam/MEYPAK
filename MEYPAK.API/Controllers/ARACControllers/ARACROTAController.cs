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
    public class ARACROTAController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAracRotaServis _aracServis;
        private MPAdoContext<MPARACROTA> _adoaracServis = new MPAdoContext<MPARACROTA>();
        public ARACROTAController(IMapper mapper, IAracRotaServis aracServis)
        {
            _mapper = mapper;
            _aracServis = aracServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult ARACROTAListe()
        {
            try
            {
                var data = _aracServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult ARACROTAListe2([FromQuery] string query)
        {
            try
            {
                _adoaracServis.HepsiniGetir(query);
                return Ok(_adoaracServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACROTAEkleyadaGuncelle([FromBody]PocoARACROTA pModel)
        {
            try
            {
                var data = _aracServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACROTASil(List<PocoARACROTA> pModel)
        {
            try
            {
                var data = _aracServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACROTAGuncelle(PocoARACROTA pModel)
        {
            try
            {
                var data = _aracServis.Guncelle(pModel);
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
                bool succes = _aracServis.DeleteById(id);
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
