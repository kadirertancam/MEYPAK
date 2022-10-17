using AutoMapper;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    [ApiController]
    [Route("[controller]")]
    public class STOKKATEGORIController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStokKategoriServis _stokKategoriServis;

        public STOKKATEGORIController(IMapper mapper, IStokKategoriServis stokKategoriServis)
        {
            _mapper = mapper;
            _stokKategoriServis = stokKategoriServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKATEGORIListe()
        {
            try
            {
                var data = _stokKategoriServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKATEGORIEkle(PocoSTOKKATEGORI pModel)
        {
            try
            {
                var data = _stokKategoriServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKATEGORISil(List<PocoSTOKKATEGORI> filter)
        {
            try
            {
                var data = _stokKategoriServis.Sil(filter);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKATEGORIGuncelle(PocoSTOKKATEGORI pModel)
        {
            try
            {
                var data = _stokKategoriServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
    }
}
