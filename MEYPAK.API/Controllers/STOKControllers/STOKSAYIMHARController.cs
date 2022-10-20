using AutoMapper;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    [ApiController]
    [Route("[controller]")]
    public class STOKSAYIMHARController : Controller
    {
        private readonly IStokSayimHarServis _stoksayimHarServis;
        private readonly IMapper _mapper;

        public STOKSAYIMHARController(IStokSayimHarServis stoksayimHarServis, IMapper mapper)
        {
            _stoksayimHarServis = stoksayimHarServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMHARListe()
        {
            try
            {
                var data = _stoksayimHarServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMHAREkle(PocoSTOKSAYIMHAR pModel)
        {
            try
            {
                var data = _stoksayimHarServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }


        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMHARSil(List<PocoSTOKSAYIMHAR> pModel)
        {
            try
            {
                var data = _stoksayimHarServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMHARGuncelle(PocoSTOKSAYIMHAR pModel)
        {
            try
            {
                var data = _stoksayimHarServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }
    }
}
