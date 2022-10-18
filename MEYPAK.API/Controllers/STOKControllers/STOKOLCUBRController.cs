using AutoMapper;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    [ApiController]
    [Route("[controller]")]
    public class STOKOLCUBRController : Controller
    {

        private readonly IMapper _mapper;
        private readonly IStokOlcuBrServis _stokOlcuBrServis;

        public STOKOLCUBRController(IMapper mapper, IStokOlcuBrServis stokOlcuBrServis)
        {
            _mapper = mapper;
            _stokOlcuBrServis = stokOlcuBrServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKOLCUBRListe()
        {
            try
            {
                var data = _stokOlcuBrServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKOLCUBREkle(PocoSTOKOLCUBR pModel)
        {
            try
            {
                var data = _stokOlcuBrServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKOLCUBRSil(List<PocoSTOKOLCUBR> pModel)
        {
            try
            {
                var data = _stokOlcuBrServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKOLCUBRGuncelle(PocoSTOKOLCUBR pModel)
        {
            try
            {
                var data = _stokOlcuBrServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
    }
}
