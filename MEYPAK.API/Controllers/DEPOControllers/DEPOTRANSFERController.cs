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
    public class DEPOTRANSFERController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IDepoTransferServis _depoTransferServis;

        public DEPOTRANSFERController(IMapper mapper, IDepoTransferServis depoTransferServis)
        {
            _mapper = mapper;
            _depoTransferServis = depoTransferServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOTRANSFERListe()
        {
            try
            {
                var data = _depoTransferServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOTRANSFEREkle(PocoDEPOTRANSFER pModel)
        {
            try
            {
                var data = _depoTransferServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOTRANSFERSil(List<PocoDEPOTRANSFER> pModel)
        {
            try
            {
                var data = _depoTransferServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOTRANSFERGuncelle(PocoDEPOTRANSFER pModel)
        {
            try
            {
                var data = _depoTransferServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oluştu!" + ex.Message);
            }
        }
    }
}
