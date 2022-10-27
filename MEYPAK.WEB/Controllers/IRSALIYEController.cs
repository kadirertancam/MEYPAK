using AutoMapper;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.Models.IRSALIYE;
using MEYPAK.Entity.PocoModels.IRSALIYE;
using MEYPAK.Entity.PocoModels.STOK;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.WEB.Controllers
{
    public class IRSALIYEController : Controller
    {
        private readonly ILogger<IRSALIYEController> _logger;
        GenericWebServis<PocoIRSALIYE> _tempPocoIrsaliye = new GenericWebServis<PocoIRSALIYE>();
        GenericWebServis<PocoIRSALIYEDETAY> _tempPocoIrsaliyeDetay = new GenericWebServis<PocoIRSALIYEDETAY>();

        public IRSALIYEController(ILogger<IRSALIYEController> logger)
        {
            _logger = logger;
        }

        #region IRSALIYE
        [HttpGet]

        public async Task<IActionResult> IrsaliyeKart()
        {
            _tempPocoIrsaliye.Data(ServisList.IrsaliyeListeServis);

            return View(_tempPocoIrsaliye.obje);
        }

        [HttpGet]
        public IActionResult IrsaliyeEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IrsaliyeEkle(PocoIRSALIYE pModel)
        {

            _tempPocoIrsaliye.Data(ServisList.IrsaliyeEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        [HttpGet]
        public IActionResult IrsaliyeSil()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IrsaliyeSil(List<PocoIRSALIYE> pModel)
        {

            _tempPocoIrsaliye.Data(ServisList.IrsaliyeSilServis,modellist: pModel);

            ViewBag.Durum = "Başarıyla silindi.";
            return View();
        }
        #endregion

        #region IRSALIYEDETAY
        [HttpGet]

        public async Task<IActionResult> IrsaliyeDetayKart()
        {
            _tempPocoIrsaliyeDetay.Data(ServisList.IrsaliyeDetayListeServis);

            return View(_tempPocoIrsaliye.obje);
        }

        [HttpGet]
        public IActionResult IrsaliyeDetayEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IrsaliyeDetayEkle(PocoIRSALIYEDETAY pModel)
        {

            _tempPocoIrsaliyeDetay.Data(ServisList.IrsaliyeDetayEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        [HttpGet]
        public IActionResult IrsaliyeDetaySil()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IrsaliyeDetaySil(List<PocoIRSALIYEDETAY> pModel)
        {

            _tempPocoIrsaliyeDetay.Data(ServisList.IrsaliyeDetayEkleServis,modellist: pModel);

            ViewBag.Durum = "Başarıyla silindi.";
            return View();
        }
        #endregion
    }
}
