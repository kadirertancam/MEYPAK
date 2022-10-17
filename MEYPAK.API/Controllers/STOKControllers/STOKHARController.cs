using AutoMapper;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOK
{
    [ApiController]
    [Route("[controller]")]
    public class STOKHARController : Controller
    {
        private readonly IStokHarServis _stokHarServis;
        private readonly IMapper _mapper;

        public STOKHARController(IStokHarServis stokHarServis, IMapper mapper)
        {
            _stokHarServis = stokHarServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKHARListe()
        {
            try
            {
                var data = _stokHarServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKHAREkle(PocoSTOKHAR pModel)
        {
            try
            {
                var data = _stokHarServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }


        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKHARSil(List<PocoSTOKHAR> pModel)
        {
            try
            {
                var data = _stokHarServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKHARGuncelle(PocoSTOKHAR pModel)
        {
            try
            {
                var data = _stokHarServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
    }
}
