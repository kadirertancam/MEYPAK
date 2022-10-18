using AutoMapper;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Interfaces.Depo;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.DEPOControllers
{
    [ApiController]
    [Route("[controller]")]
    public class DEPOTRANSFERHARController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IDepoTransferHarServis _depoTransferHarServis;

        public DEPOTRANSFERHARController(IMapper mapper, IDepoTransferHarServis depoTransferHarServis)
        {
            _mapper = mapper;
            _depoTransferHarServis = depoTransferHarServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOTRANSFERHARListe()
        {
            try
            {
                var data = _depoTransferHarServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOTRANSFERHAREkle(PocoDEPOTRANSFERHAR pModel)
        {
            try
            {
                var data = _depoTransferHarServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOTRANSFERHARSil(List<PocoDEPOTRANSFERHAR> pModel)
        {
            try
            {
                var data = _depoTransferHarServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOTRANSFERHARGuncelle(PocoDEPOTRANSFERHAR pModel)
        {
            try
            {
                var data = _depoTransferHarServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }
    }
}
