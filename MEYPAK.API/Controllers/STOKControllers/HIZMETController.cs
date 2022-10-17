using AutoMapper;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Hizmet;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    [ApiController]
    [Route("[controller]")]
    public class HIZMETController : Controller
    {
        private readonly IHizmetServis _hizmetServis; 
        private readonly IMapper _mapper;

        public HIZMETController(IHizmetServis hizmetServis, IMapper mapper)
        {
            _hizmetServis = hizmetServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult HIZMETListe()
        {
            try
            {
                var data = _hizmetServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult HIZMETEkle(PocoHIZMET pModel)
        {
            try
            {
                var data = _hizmetServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult HIZMETSil(List<PocoHIZMET> pModel)
        {
            try
            {
                var data = _hizmetServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult HIZMETGuncelle(PocoHIZMET pModel)
        {
            try
            {
                var data = _hizmetServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
    }
}
