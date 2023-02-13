using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.PARAMETRE;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Interfaces.Parametre;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.PARAMETREControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class KasaParamsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IKasaParamServis KasaParamServis;
        private MPAdoContext<MPKASAPARAMS> _adoKasaParamsServis;
        public KasaParamsController(IMapper mapper, IKasaParamServis cariServis)
        {
            _mapper = mapper;
            KasaParamServis = cariServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult KasaParamsListe()
        {
            try
            {
                var data = KasaParamServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult KasaParamsListe2([FromQuery] string query)
        {
            try
            {
                _adoKasaParamsServis.HepsiniGetir(query);
                return Ok(_adoKasaParamsServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult KasaParamsEkleyadaGuncelle(PocoKASAPARAMS pModel)
        {
            try
            {
                var data = KasaParamServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult KasaParamsSil(List<PocoKASAPARAMS> pModel)
        {
            try
            {
                var data = KasaParamServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult KasaParamsGuncelle(PocoKASAPARAMS pModel)
        {
            try
            {
                var data = KasaParamServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

    }
}
