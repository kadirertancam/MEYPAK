using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.EISLEMLER;
using MEYPAK.Entity.Models.FATURA;
using MEYPAK.Entity.PocoModels.EISLEMLER;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Interfaces.EIslemler;
using MEYPAK.Interfaces.Fatura;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.EISLEMLER
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class GELENEFATURAController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGelenFaturaServis _gelenEFaturaServis;
        private MPAdoContext<MPGELENEFATURA> _adoGelenEFaturaServis = new MPAdoContext<MPGELENEFATURA>();
        public GELENEFATURAController(IMapper mapper, IGelenFaturaServis faturaServis)
        {
            _mapper = mapper;
            _gelenEFaturaServis = faturaServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult GELENEFATURAListe()
        {
            try
            {
                var data = _gelenEFaturaServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult GELENEFATURAListe2([FromQuery] string query)
        {
            try
            {
                _adoGelenEFaturaServis.HepsiniGetir(query);
                return Ok(_adoGelenEFaturaServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult GELENEFATURAEKleyadaGuncelle(PocoGELENEFATURA pModel)
        {
            try
            {
                var data = _gelenEFaturaServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult GELENEFATURASil(List<PocoGELENEFATURA> pModel)
        {
            try
            {
                var data = _gelenEFaturaServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult GELENEFATURAGuncelle(PocoGELENEFATURA pModel)
        {
            try
            {
                var data = _gelenEFaturaServis.Guncelle(pModel);
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
                bool succes = _gelenEFaturaServis.DeleteById(id);
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
