using AutoMapper;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Stok;
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
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOTRANSFERHAREkleyadaGuncelle(PocoDEPOTRANSFERHAR pModel)
        {
            try
            {
                var data = _depoTransferHarServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
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
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
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
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult DeleteById([FromBody] int id)
        {
            try
            {
                bool succes = _depoTransferHarServis.DeleteById(id);
                if (succes)
                    return Ok(id + " Başarıyla Silindi");
                else
                    return Ok(id + " Silinemedi.");
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
    }
}
