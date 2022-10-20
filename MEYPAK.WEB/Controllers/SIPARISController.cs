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



    }
}
