using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.ARAC;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Arac;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.ARAC
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ARACController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAracServis _aracServis;
        private MPAdoContext<MPARAC> _adoaracServis = new MPAdoContext<MPARAC>();
        public ARACController(IMapper mapper, IAracServis aracServis)
        {
            _mapper = mapper;
            _aracServis = aracServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult ARACListe()
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
        public IActionResult ARACListe2([FromQuery] string query)
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
        public IActionResult ARACEkleyadaGuncelle(PocoARAC pModel)
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
        public IActionResult ARACSil(List<PocoARAC> pModel)
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
        public IActionResult ARACGuncelle(PocoARAC pModel)
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
        [HttpPost]
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
