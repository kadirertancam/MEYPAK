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
    public class FATURASTOKESLEController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFaturaStokEsleServis _faturaStokEsleServis;
        private MPAdoContext<MPFATURASTOKESLE> _adoFaturaStokEsleServis = new MPAdoContext<MPFATURASTOKESLE>();
        public FATURASTOKESLEController(IMapper mapper, IFaturaStokEsleServis faturaDetayServis)
        {
            _mapper = mapper;
            _faturaStokEsleServis = faturaDetayServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult FATURASTOKESLEListe()
        {
            try
            {
                var data = _faturaStokEsleServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult FATURASTOKESLEListe2([FromQuery] string query)
        {
            try
            {
                _adoFaturaStokEsleServis.HepsiniGetir(query);
                return Ok(_adoFaturaStokEsleServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult FATURASTOKESLEEkleyadaGuncelle(PocoFATURASTOKESLE pModel)
        {
            try
            {
                var data = _faturaStokEsleServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult FATURASTOKESLESil(List<PocoFATURASTOKESLE> pModel)
        {
            try
            {
                var data = _faturaStokEsleServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult FATURASTOKESLEGuncelle(PocoFATURASTOKESLE pModel)
        {
            try
            {
                var data = _faturaStokEsleServis.Guncelle(pModel);
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
                bool succes = _faturaStokEsleServis.DeleteById(id);
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


