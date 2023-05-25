using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.FATURA;
using MEYPAK.Entity.PocoModels.FATURA;
using MEYPAK.Interfaces.Fatura;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.FATURAController
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class FATURATASLAKController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFaturaTaslakServis _faturaServis;
        private MPAdoContext<MPFATURATASLAK> _adoFaturaServis = new MPAdoContext<MPFATURATASLAK>();
        public FATURATASLAKController(IMapper mapper, IFaturaTaslakServis faturaServis)
        {
            _mapper = mapper;
            _faturaServis = faturaServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult Liste()
        {
            try
            {
                var data = _faturaServis.Listele();
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
                _adoFaturaServis.HepsiniGetir(query);
                return Ok(_adoFaturaServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult EKleyadaGuncelle(PocoFATURATASLAK pModel)
        {
            try
            {
                var data = _faturaServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Sil(List<PocoFATURATASLAK> pModel)
        {
            try
            {
                var data = _faturaServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Guncelle(PocoFATURATASLAK pModel)
        {
            try
            {
                var data = _faturaServis.Guncelle(pModel);
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
                bool succes = _faturaServis.DeleteById(id);
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
