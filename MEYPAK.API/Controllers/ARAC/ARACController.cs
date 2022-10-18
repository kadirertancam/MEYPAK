using AutoMapper;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Arac;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.ARAC
{
    [ApiController]
    [Route("[controller]")]
    public class ARACController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAracServis _aracServis;

        public ARACController(IMapper mapper, IAracServis aracServis)
        {
            _mapper = mapper;
            _aracServis = aracServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult ARACListe()
        {
            try
            {
                var data = _aracServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACEkle(PocoARACLAR pModel)
        {
            try
            {
                var data = _aracServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACSil(List<PocoARACLAR> pModel)
        {
            try
            {
                var data = _aracServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACGuncelle(PocoARACLAR pModel)
        {
            try
            {
                var data = _aracServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
    }
}
