using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.STOK;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.WEB.Controllers
{
    public class DEPOController : Controller
    {
        private readonly ILogger<DEPOController> _logger;
        GenericWebServis<PocoDEPO> _tempPocoDepo = new GenericWebServis<PocoDEPO>();
        GenericWebServis<PocoDEPOEMIR> _tempPocoDepoEmir = new GenericWebServis<PocoDEPOEMIR>();

        public DEPOController(ILogger<DEPOController> logger)
        {
            _logger = logger;
        }

        #region DEPO
        [HttpGet]

        public async Task<IActionResult> DepoKart()
        {
            _tempPocoDepo.Data(ServisList.DepoListeServis);

            return View(_tempPocoDepo.obje);
        }

        [HttpGet]
        public IActionResult DepoEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DepoEkle(PocoDEPO pModel)
        {

            _tempPocoDepo.Data(ServisList.DepoEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        #endregion

        #region DEPOEMIR
        [HttpGet]

        public async Task<IActionResult> DepoEmirKart()
        {
            _tempPocoDepoEmir.Data(ServisList.DepoEmirListeServis);

            return View(_tempPocoDepoEmir.obje);
        }

        [HttpGet]
        public IActionResult DepoEmirEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DepoEmirEkle(PocoDEPOEMIR pModel)
        {

            _tempPocoDepo.Data(ServisList.DepoEmirEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        #endregion
    }
}
