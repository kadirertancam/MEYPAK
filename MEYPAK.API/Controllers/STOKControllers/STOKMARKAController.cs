using AutoMapper;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    [ApiController]
    [Route("[controller]")]
    public class STOKMARKAController : Controller
    {
        private readonly IStokMarkaServis _stokMarkaServis;
        private readonly IMapper _mapper;

        public STOKMARKAController(IStokMarkaServis stokMarkaServis, IMapper mapper)
        {
            _stokMarkaServis = stokMarkaServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMARKAListe()
        {
            try
            {
                var data = _stokMarkaServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMARKAEkle(PocoSTOKMARKA pModel)
        {
            try
            {
                var data = _stokMarkaServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMARKASil(List<PocoSTOKMARKA> pModel)
        {
            try
            {
                var data = _stokMarkaServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMARKAGuncelle(PocoSTOKMARKA pModel)
        {
            try
            {
                var data = _stokMarkaServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
    }
}
