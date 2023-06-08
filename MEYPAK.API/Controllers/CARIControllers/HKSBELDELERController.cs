using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Interfaces.Cari;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.CARIControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class HKSBELDELERController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IHksBeldelerServis _HksBeldelerServis;
        private MPAdoContext<MPHKSBELDELER> _adocariServis = new MPAdoContext<MPHKSBELDELER>();
        public HKSBELDELERController(IMapper mapper, IHksBeldelerServis HksBeldelerServis)
        {
            _mapper = mapper;
            _HksBeldelerServis = HksBeldelerServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult HksBeldelerListe()
        {
            try
            {
                var data = _HksBeldelerServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult HksBeldelerListe2([FromQuery] string query)
        {
            try
            {
                _adocariServis.HepsiniGetir(query);
                return Ok(_adocariServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult HksBeldelerEkleyadaGuncelle([FromBody] PocoHKSBELDELER pModel)
        {
            try
            {
                var data = _HksBeldelerServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult HksBeldelerSil(List<PocoHKSBELDELER> pModel)
        {
            try
            {
                var data = _HksBeldelerServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult HksBeldelerGuncelle(PocoHKSBELDELER pModel)
        {
            try
            {
                var data = _HksBeldelerServis.Guncelle(pModel);
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
                bool succes = _HksBeldelerServis.DeleteById(id);
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
