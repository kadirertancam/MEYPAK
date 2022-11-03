using AutoMapper;
using MEYPAK.DAL.Abstract.DepoDal;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.DEPOControllers
{
    [ApiController]
    [Route("[controller]")]
    public class DEPOEMIRController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IDepoEmirServis _depoEmirServis;
        private MPAdoContext<MPDEPOEMIR> _adodepoEmirServis = new MPAdoContext<MPDEPOEMIR>();
        public DEPOEMIRController(IMapper mapper, IDepoEmirServis depoEmirServis)
        {
            _mapper = mapper;
            _depoEmirServis = depoEmirServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOEMIRListe()
        {
            try
            {
                var data = _depoEmirServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOEMIRListe2([FromQuery] string query)
        {
            try
            {
                _adodepoEmirServis.HepsiniGetir(query);
                return Ok(_adodepoEmirServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOEMIREkleyadaGuncelle(PocoDEPOEMIR pModel)
        {
            try
            {
                var data = _depoEmirServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOEMIRSil(List<PocoDEPOEMIR> pModel)
        {
            try
            {
                var data = _depoEmirServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOEMIRGuncelle(PocoDEPOEMIR pModel)
        {
            try
            {
                var data = _depoEmirServis.Guncelle(pModel);
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
                bool succes = _depoEmirServis.DeleteById(id);
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
