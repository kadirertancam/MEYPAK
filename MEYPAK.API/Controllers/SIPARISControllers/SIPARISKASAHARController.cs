using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Interfaces.Siparis;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.SIPARISControllers
{
    public class SIPARISKASAHARController : Controller
    {
        private readonly ISiparisKasaHarServis _siparisKasaHarServis;
        private readonly IMapper _mapper;
        private MPAdoContext<MPSIPARISKASAHAR> _adosiparisKasaHarServis; //= new MPAdoContext<MPSIPARISDETAY>();
        public SIPARISKASAHARController(ISiparisKasaHarServis siparisKasaHarServis, IMapper mapper)
        {
            _siparisKasaHarServis = siparisKasaHarServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISDETAYListe()
        {
            try
            {
                var data = _siparisKasaHarServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISDETAYListe2([FromQuery] string query)
        {
            try
            {
                _adosiparisKasaHarServis.HepsiniGetir(query);

                return Ok(_adosiparisKasaHarServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISKASAHAREkleyadaGuncelle(PocoSIPARISKASAHAR pModel)
        {
            try
            {
                var data = _siparisKasaHarServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISKASAHARSil(List<PocoSIPARISKASAHAR> pModel)
        {
            try
            {
                var data = _siparisKasaHarServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISKASAHARGuncelle(PocoSIPARISKASAHAR pModel)
        {
            try
            {
                var data = _siparisKasaHarServis.Guncelle(pModel);
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
                bool succes = _siparisKasaHarServis.DeleteById(id);
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
