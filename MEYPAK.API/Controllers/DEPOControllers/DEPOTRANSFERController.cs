using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.DEPO;
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
        private MPAdoContext<MPDEPOTRANSFER> _adodepoTransferServis = new MPAdoContext<MPDEPOTRANSFER>();
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
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOTRANSFERListe2([FromQuery] string query)
        {
            try
            {
                _adodepoTransferServis.HepsiniGetir(query);
                return Ok(_adodepoTransferServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOTRANSFEREkleyadaGuncelle(PocoDEPOTRANSFER pModel)
        {
            try
            {
                var data = _depoTransferServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
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
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
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
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DeleteById([FromBody] int id)
        {
            try
            {
                bool succes = _depoTransferServis.DeleteById(id);
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
