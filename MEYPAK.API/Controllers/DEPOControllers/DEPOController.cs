using AutoMapper;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.DEPOControllers
{
    [ApiController]
    [Route("[controller]")]
    public class DEPOController : Controller
    {

        private readonly IMapper _mapper;
        private readonly IDepoServis _depoServis;

        public DEPOController(IMapper mapper, IDepoServis depoServis)
        {
            _mapper = mapper;
            _depoServis = depoServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOListe()
        {
            try
            {
                var data = _depoServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOEkle(PocoDEPO pModel)
        {
            try
            {
                var data = _depoServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOSil(List<PocoDEPO> pModel)
        {
            try
            {
                var data = _depoServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOGuncelle(PocoDEPO pModel)
        {
            try
            {
                var data = _depoServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
    }
}
