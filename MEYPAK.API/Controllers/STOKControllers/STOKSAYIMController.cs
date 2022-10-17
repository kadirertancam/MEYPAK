using AutoMapper;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    [ApiController]
    [Route("[controller]")]
    public class STOKSAYIMController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStokSayimServis _stoksayimServis;

        public STOKSAYIMController(IMapper mapper, IStokSayimServis stoksayimServis)
        {
            _mapper = mapper;
            _stoksayimServis = stoksayimServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMListe()
        {
            try
            {
                var data = _stoksayimServis.Listele();
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMEkle(PocoSTOKSAYIM pModel)
        {
            try
            {
                var data = _stoksayimServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMSil(List<PocoSTOKSAYIM> pModel)
        {
            try
            {
                var data = _stoksayimServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMGuncelle(PocoSTOKSAYIM pModel)
        {
            try
            {
                var data = _stoksayimServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception)
            {
                return Problem("Beklenmedik bir hata oluştu!");
            }
        }
    }
}
