using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.SIPARIS;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Interfaces.Siparis;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.SIPARISControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class SIPARISSEVKEMRIHARController : Controller
    {
        private readonly ISiparisSevkEmriHarServis _siparisSevkEmriHarServis;
        private readonly IMapper _mapper;
        private MPAdoContext<MPSIPARISSEVKEMRIHAR> _adosiparisSevkEmriHarServis = new MPAdoContext<MPSIPARISSEVKEMRIHAR>();
        public SIPARISSEVKEMRIHARController(ISiparisSevkEmriHarServis siparisSevkEmriHarServis, IMapper mapper)
        {
            _siparisSevkEmriHarServis = siparisSevkEmriHarServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISSEVKEMRIHARListe()
        {
            try
            {
                var data = _siparisSevkEmriHarServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISSEVKEMRIHARListe2([FromQuery] string query)
        {
            try
            {
                _adosiparisSevkEmriHarServis.HepsiniGetir(query);

                return Ok(_adosiparisSevkEmriHarServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISSEVKEMRIHAREkleyadaGuncelle(PocoSIPARISSEVKEMIRHAR pModel)
        {
            try
            {
                var data = _siparisSevkEmriHarServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISSEVKEMRIHARSil(List<PocoSIPARISSEVKEMIRHAR> pModel)
        {
            try
            {
                var data = _siparisSevkEmriHarServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SIPARISSEVKEMRIHARGuncelle(PocoSIPARISSEVKEMIRHAR pModel)
        {
            try
            {
                var data = _siparisSevkEmriHarServis.Guncelle(pModel);
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
                bool succes = _siparisSevkEmriHarServis.DeleteById(id);
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
