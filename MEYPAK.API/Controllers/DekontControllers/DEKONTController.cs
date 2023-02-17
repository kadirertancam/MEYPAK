using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.DEKONT;
using MEYPAK.Entity.Models.DEKONT;
using MEYPAK.Entity.PocoModels.DEKONT;
using MEYPAK.Interfaces.Dekont;
using MEYPAK.Interfaces.Fatura;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.DekontControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class DEKONTController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IDekontServis _dekontServis;
        private MPAdoContext<MPDEKONT> _adoDekontServis = new MPAdoContext<MPDEKONT>();
        public DEKONTController(IMapper mapper, IDekontServis dekontServis)
        {
            _mapper = mapper;
            _dekontServis = dekontServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult DEKONTListe()
        {
            try
            {
                var data = _dekontServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult DEKONTListe2([FromQuery] string query)
        {
            try
            {
                _adoDekontServis.HepsiniGetir(query);
                return Ok(_adoDekontServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEKONTEKleyadaGuncelle(PocoDEKONT pModel)
        {
            try
            {
                var data = _dekontServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEKONTSil(List<PocoDEKONT> pModel)
        {
            try
            {
                var data = _dekontServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEKONTGuncelle(PocoDEKONT pModel)
        {
            try
            {
                var data = _dekontServis.Guncelle(pModel);
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
                bool succes = _dekontServis.DeleteById(id);
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
