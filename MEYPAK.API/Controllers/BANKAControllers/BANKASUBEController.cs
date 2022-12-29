using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.BANKA;
using MEYPAK.Entity.PocoModels.BANKA;
using MEYPAK.Interfaces.Banka;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.BANKAControllers
{
    [ApiController]
    [Route("[controller]")]
    public class BANKASUBEController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBankaSubeServis _bankaServis;
        private MPAdoContext<MPBANKASUBE> _adobankaServis = new MPAdoContext<MPBANKASUBE>();
        public BANKASUBEController(IMapper mapper, IBankaSubeServis bankaServis)
        {
            _mapper = mapper;
            _bankaServis = bankaServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult BANKASUBEListe()
        {
            try
            {
                var data = _bankaServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult BANKASUBEListe2([FromQuery] string query)
        {
            try
            {
                _adobankaServis.HepsiniGetir(query);
                return Ok(_adobankaServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult BANKASUBEEkleyadaGuncelle([FromBody] PocoBANKASUBE pModel)
        {
            try
            {
                var data = _bankaServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult BANKASUBESil(List<PocoBANKASUBE> pModel)
        {
            try
            {
                var data = _bankaServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult BANKASUBEGuncelle(PocoBANKASUBE pModel)
        {
            try
            {
                var data = _bankaServis.Guncelle(pModel);
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
                bool succes = _bankaServis.DeleteById(id);
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
