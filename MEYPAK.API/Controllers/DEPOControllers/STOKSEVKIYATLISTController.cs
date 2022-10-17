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
    public class STOKSEVKIYATLISTController : Controller
    {

        private readonly IMapper _mapper;
        private readonly IStokSevkiyatListServis _stokSevkiyatListServis;

        public STOKSEVKIYATLISTController(IMapper mapper, IStokSevkiyatListServis stokSevkiyatListServis)
        {
            _mapper = mapper;
            _stokSevkiyatListServis = stokSevkiyatListServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSEVKIYATLISTListe()
        {
            try
            {
                var data = _stokSevkiyatListServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSEVKIYATLISTEkle(PocoSTOKSEVKIYATLIST pModel)
        {
            try
            {
                var data = _stokSevkiyatListServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSEVKIYATLISTSil(List<PocoSTOKSEVKIYATLIST> pModel)
        {
            try
            {
                var data = _stokSevkiyatListServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSEVKIYATLISTGuncelle(PocoSTOKSEVKIYATLIST pModel)
        {
            try
            {
                var data = _stokSevkiyatListServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
    }
}
