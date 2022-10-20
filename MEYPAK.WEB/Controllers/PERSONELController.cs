using AutoMapper;
using MEYPAK.BLL.Assets;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Entity.PocoModels.STOK;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.WEB.Controllers
{
    public class PERSONELController : Controller
    {
        private readonly ILogger<PERSONELController> _logger;
        GenericWebServis<PocoPERSONEL> _tempPocoPersonel = new GenericWebServis<PocoPERSONEL>();

        public PERSONELController(ILogger<PERSONELController> logger)
        {
            _logger = logger;
        }


        #region PERSONEL
        [HttpGet]

        public async Task<IActionResult> PersonelKart()
        {
            _tempPocoPersonel.Data(ServisList.PersonelListeServis);

            return View(_tempPocoPersonel.obje);
        }

        [HttpGet]
        public IActionResult PersonelEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PersonelEkle(PocoPERSONEL pModel)
        {

            _tempPocoPersonel.Data(ServisList.PersonelEkleServis, pModel);

            ViewBag.Durum = "Başarıyla eklendi.";
            return View();
        }
        #endregion



    }
}
