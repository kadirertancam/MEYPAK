using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.BANKA;
using MEYPAK.Entity.PocoModels.BANKA;
using MEYPAK.Interfaces.Banka;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.BANKAControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class BANKAHESAPController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBankaHesapServis _bankaServis;
        private MPAdoContext<MPBANKAHESAP> _adobankaServis = new MPAdoContext<MPBANKAHESAP>();
        public BANKAHESAPController(IMapper mapper, IBankaHesapServis bankaServis)
        {
            _mapper = mapper;
            _bankaServis = bankaServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult BANKAHESAPListe()
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
        public IActionResult BANKAHESAPListe2([FromQuery] string query)
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
        public IActionResult BANKAHESAPEkleyadaGuncelle([FromBody] PocoBANKAHESAP pModel)
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
        public IActionResult BANKAHESAPSil(List<PocoBANKAHESAP> pModel)
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
        public IActionResult BANKAHESAPGuncelle(PocoBANKAHESAP pModel)
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
