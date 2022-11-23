using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.FATURA;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Interfaces.Fatura;
using MEYPAK.Interfaces.IRSALIYE;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.FATURAController
{
    [ApiController]
    [Route("[controller]")]
    public class FATURAController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFaturaServis _faturaServis;
        private MPAdoContext<MPFATURA> _adoFaturaServis = new MPAdoContext<MPFATURA>();
        public FATURAController(IMapper mapper, IFaturaServis faturaServis)
        {
            _mapper = mapper;
            _faturaServis = faturaServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult FATURAListe()
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
        public IActionResult FATURAListe2([FromQuery] string query)
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
        public IActionResult FATURAkleyadaGuncelle(PocoFATURA pModel)
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
        public IActionResult FATURASil(List<PocoFATURA> pModel)
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
        public IActionResult FATURAGuncelle(PocoFATURA pModel)
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
