using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.SIPARIS;
using MEYPAK.Entity.PocoModels.STOK;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.WEB.Controllers
{
    public class SIPARISController : Controller
    {
        private readonly ILogger<SIPARISController> _logger;
        GenericWebServis<PocoSIPARIS> _tempPocoSiparis = new GenericWebServis<PocoSIPARIS>();
        GenericWebServis<PocoSIPARISDETAY> _tempPocoSiparisDetay = new GenericWebServis<PocoSIPARISDETAY>();
        GenericWebServis<PocoSIPARISSEVKEMIRHAR> _tempPocoSiparisSevkEmriHar = new GenericWebServis<PocoSIPARISSEVKEMIRHAR>();

        public SIPARISController(ILogger<SIPARISController> logger)
        {
            _logger = logger;
        }


        #region SIPARIS

        [HttpGet]

        public async Task<IActionResult> SiparisKart()
        {
            _tempPocoSiparis.Data(ServisList.SiparisListeServis);

            return View(_tempPocoSiparis.obje);
        }

        [HttpGet]
        public IActionResult SiparisEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SiparisEkle(PocoSIPARIS pModel)
        {

            _tempPocoSiparis.Data(ServisList.SiparisEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }


        #endregion

        #region SIPARISDETAY

        [HttpGet]

        public async Task<IActionResult> SiparisDetayKart()
        {
            _tempPocoSiparisDetay.Data(ServisList.SiparisDetayListeServis);

            return View(_tempPocoSiparisDetay.obje);
        }

        [HttpGet]
        public IActionResult SiparisDetayEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SiparisDetayEkle(PocoSIPARISDETAY pModel)
        {

            _tempPocoSiparisDetay.Data(ServisList.SiparisDetayEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }


        #endregion

        #region SIPARIS

        [HttpGet]

        public async Task<IActionResult> SiparisSevkEmriKart()
        {
            _tempPocoSiparisSevkEmriHar.Data(ServisList.SiparisSevkEmriHarListeServis);

            return View(_tempPocoSiparisSevkEmriHar.obje);
        }

        [HttpGet]
        public IActionResult SiparisSevkEmriEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SiparisSevkEmriEkle(PocoSIPARISSEVKEMIRHAR pModel)
        {

            _tempPocoSiparisSevkEmriHar.Data(ServisList.SiparisSevkEmriHarEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }


        #endregion

    }
}
