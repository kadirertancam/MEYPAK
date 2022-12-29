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
    public class HESAPHARController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IHesapHarServis _bankaServis;
        private MPAdoContext<MPBANKAHESAP> _adobankaServis = new MPAdoContext<MPBANKAHESAP>();
        public HESAPHARController(IMapper mapper, IHesapHarServis bankaServis)
        {
            _mapper = mapper;
            _bankaServis = bankaServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult HESAPHARListe()
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
        public IActionResult HESAPHARListe2([FromQuery] string query)
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
        public IActionResult HESAPHAREkleyadaGuncelle([FromBody] PocoHESAPHAREKET pModel)
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
        public IActionResult HESAPHARSil(List<PocoHESAPHAREKET> pModel)
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
        public IActionResult HESAPHARGuncelle(PocoHESAPHAREKET pModel)
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
