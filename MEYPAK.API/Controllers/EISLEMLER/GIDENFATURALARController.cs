using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.EISLEMLER;
using MEYPAK.Entity.PocoModels.EISLEMLER;
using MEYPAK.Interfaces.EIslemler;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.EISLEMLER
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class GIDENFATURALARController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGidenFaturalarServis _gidenFaturalarServis;
        private MPAdoContext<MPGIDENFATURALAR> _adoGIDENFATURALARServis = new MPAdoContext<MPGIDENFATURALAR>();
        public GIDENFATURALARController(IMapper mapper, IGidenFaturalarServis faturaServis)
        {
            _mapper = mapper;
            _gidenFaturalarServis = faturaServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult Liste()
        {
            try
            {
                var data = _gidenFaturalarServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult Liste2([FromQuery] string query)
        {
            try
            {
                _adoGIDENFATURALARServis.HepsiniGetir(query);
                return Ok(_adoGIDENFATURALARServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult EKleyadaGuncelle(PocoGIDENFATURALAR pModel)
        {
            try
            {
                var data = _gidenFaturalarServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult GIDENFATURALARSil(List<PocoGIDENFATURALAR> pModel)
        {
            try
            {
                var data = _gidenFaturalarServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult  Guncelle(PocoGIDENFATURALAR pModel)
        {
            try
            {
                var data = _gidenFaturalarServis.Guncelle(pModel);
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
                bool succes = _gidenFaturalarServis.DeleteById(id);
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
