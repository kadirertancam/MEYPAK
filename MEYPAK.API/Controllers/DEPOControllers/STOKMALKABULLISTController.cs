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
    public class STOKMALKABULLISTController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStokMalKabulListServis _stokMalKabulListServis;

        public STOKMALKABULLISTController(IMapper mapper, IStokMalKabulListServis stokMalKabulListServis)
        {
            _mapper = mapper;
            _stokMalKabulListServis = stokMalKabulListServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMALKABULLISTListe()
        {
            try
            {
                var data = _stokMalKabulListServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMALKABULLISTEkle(PocoSTOKMALKABULLIST pModel)
        {
            try
            {
                var data = _stokMalKabulListServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMALKABULLISTSil(List<PocoSTOKMALKABULLIST> pModel)
        {
            try
            {
                var data = _stokMalKabulListServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMALKABULLISTGuncelle(PocoSTOKMALKABULLIST pModel)
        {
            try
            {
                var data = _stokMalKabulListServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }
    }
}
