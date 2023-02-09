using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Interfaces.Siparis;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.SIPARISControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class SATINALMAMALKABULEMRIHARController : Controller
    {
        private readonly ISatinAlmaMalKabulEmriHarServis _satinAlmaMalKabulEmriHarServis;
        private readonly IMapper _mapper;
        private MPAdoContext<MPSATINALMAMALKABULEMRIHAR> _adosatinAlmaMalKabulEmriHarServis = new MPAdoContext<MPSATINALMAMALKABULEMRIHAR>();
        public SATINALMAMALKABULEMRIHARController(ISatinAlmaMalKabulEmriHarServis satinAlmaMalKabulEmriHarServis, IMapper mapper)
        {
            _satinAlmaMalKabulEmriHarServis = satinAlmaMalKabulEmriHarServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult SATINALMAMALKABULEMRIHARListe()
        {
            try
            {
                var data = _satinAlmaMalKabulEmriHarServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult SATINALMAMALKABULEMRIHARListe2([FromQuery] string query)
        {
            try
            {
                _adosatinAlmaMalKabulEmriHarServis.HepsiniGetir(query);

                return Ok(_adosatinAlmaMalKabulEmriHarServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SATINALMAMALKABULEMRIHAREkleyadaGuncelle(PocoSATINALMAMALKABULEMRIHAR pModel)
        {
            try
            {
                var data = _satinAlmaMalKabulEmriHarServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SATINALMAMALKABULEMRIHARSil(List<PocoSATINALMAMALKABULEMRIHAR> pModel)
        {
            try
            {
                var data = _satinAlmaMalKabulEmriHarServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SATINALMAMALKABULEMRIHARGuncelle(PocoSATINALMAMALKABULEMRIHAR pModel)
        {
            try
            {
                var data = _satinAlmaMalKabulEmriHarServis.Guncelle(pModel);
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
                bool succes = _satinAlmaMalKabulEmriHarServis.DeleteById(id);
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
