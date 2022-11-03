using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.SIPARISControllers
{
    [ApiController]
    [Route("[controller]")]
    public class SIPARISDETAYController : Controller
    {
        private readonly ISiparisDetayServis _siparisDetayServis;
        private readonly IMapper _mapper;
        private MPAdoContext<MPSIPARISDETAY> _adosiparisDetayServis = new MPAdoContext<MPSIPARISDETAY>();
        public SIPARISDETAYController(ISiparisDetayServis siparisDetayServis, IMapper mapper)
        {
            _siparisDetayServis = siparisDetayServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISDETAYListe()
        {
            try
            {
                var data = _siparisDetayServis.Listele();
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
                _adosiparisDetayServis.HepsiniGetir(query);

                return Ok(_adosiparisDetayServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISDETAYEkleyadaGuncelle(PocoSIPARISDETAY pModel)
        {
            try
            {
                var data = _siparisDetayServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISDETAYSil(List<PocoSIPARISDETAY> pModel)
        {
            try
            {
                var data = _siparisDetayServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISDETAYGuncelle(PocoSIPARISDETAY pModel)
        {
            try
            {
                var data = _siparisDetayServis.Guncelle(pModel);
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
                bool succes = _siparisDetayServis.DeleteById(id);
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
