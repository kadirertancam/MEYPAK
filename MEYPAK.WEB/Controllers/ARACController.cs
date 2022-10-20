using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Entity.PocoModels.STOK;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.WEB.Controllers
{
    public class ARACController : Controller
    {
        private readonly ILogger<ARACController> _logger;
        GenericWebServis<PocoARACLAR> _tempPocoArac = new GenericWebServis<PocoARACLAR>();
        public ARACController(ILogger<ARACController> logger)
        {
            _logger = logger;

        }
            #region ARAC
            [HttpGet] 
            public async Task<IActionResult> AracKart()
            {
                _tempPocoArac.Data(ServisList.AracListeServis);

                return View(_tempPocoArac.obje);
            }

            [HttpGet]
            public IActionResult AracEkle()
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> AracEkle(PocoARACLAR pModel)
            {

                _tempPocoArac.Data(ServisList.AracEkleServis, pModel);

                ViewBag.Durum = "Başarıyla eklendi.";
                return View();
            }
            #endregion
        }
    }

