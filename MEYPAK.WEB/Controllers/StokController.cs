using MEYPAK.DAL.Concrete.EntityFramework.Context;
using Microsoft.AspNetCore.Mvc;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.BLL.STOK;
using MEYPAK.Entity.Models;
using MEYPAK.Interfaces.Stok;
using MEYPAK.WEB.Models;

namespace MEYPAK.WEB.Controllers
{
    public class StokController : Controller

    {
        static MEYPAKContext context = new MEYPAKContext();

        private readonly IStokServis _stokServis = new StokManager(new EFStokRepo(context));
        private readonly ILogger<StokController> _logger;

        public StokController(ILogger<StokController> logger)
        {
            _logger = logger;
        }


        public IActionResult StokKart()
        {
           
                List<MPSTOK> data = _stokServis.Listele();
                return View(data);
        }
        [HttpPost]
        public IActionResult StokKart(List<MPSTOK> mPSTOKs)
        {

         
            return View();
        }
        public IActionResult StokEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StokEkle(MPSTOK mpStok)
        {
           
            return View(ViewBag.Durum="Başarıyla eklendi.");
        }
    }
}
