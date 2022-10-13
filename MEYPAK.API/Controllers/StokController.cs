using MEYPAK.BLL.STOK;
using MEYPAK.DAL.Concrete.EntityFramework.Context;
using MEYPAK.DAL.Concrete.EntityFramework.Repository;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StokController : Controller
    {
        static MEYPAKContext context = new MEYPAKContext();
        private readonly IStokServis _stokServis = new StokManager(new EFStokRepo(context));

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult StoklarıGetir()
        {
            try
            {
                var data = _stokServis.Listele().Select(x=> new 
                {
                   x.ID,
                   x.KOD ,
                   x.ADI,
                   x.AFIYAT1,
                   x.SFIYAT1,
                   x.ACIKLAMA
                   
                });
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult StokEkle(MPSTOK model)
        {
            try
            {
                _stokServis.Ekle(model);
                return Ok("Başarıyla eklendi");
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }


    }
}
