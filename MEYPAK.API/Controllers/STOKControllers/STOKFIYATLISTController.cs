using AutoMapper;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOK
{
    [ApiController]
    [Route("[controller]")]
    public class STOKFIYATLISTController : Controller
    {


        private readonly IStokFiyatListServis _stokFiyatListServis;
        private readonly IMapper _mapper;

        public STOKFIYATLISTController(IStokFiyatListServis stokFiyatListServis, IMapper mapper)
        {
            _stokFiyatListServis = stokFiyatListServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATLISTListe()
        {
            try
            {
                var data = _stokFiyatListServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATLISTEkle(PocoSTOKFIYATLIST pModel)
        {
            try
            {
                var data = _stokFiyatListServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATLISTSil(List<PocoSTOKFIYATLIST> pModel)
        {
            try
            {
                var data = _stokFiyatListServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATLISTGuncelle(PocoSTOKFIYATLIST pModel)
        {
            try
            {
                var data = _stokFiyatListServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
    }
}
