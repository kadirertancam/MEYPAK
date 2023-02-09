using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class STOKOLCUBRController : Controller
    {

        private readonly IMapper _mapper;
        private readonly IStokOlcuBrServis _stokOlcuBrServis;
        private MPAdoContext<MPSTOKOLCUBR> _adostokOlcuBrServis = new MPAdoContext<MPSTOKOLCUBR>();
        public STOKOLCUBRController(IMapper mapper, IStokOlcuBrServis stokOlcuBrServis)
        {
            _mapper = mapper;
            _stokOlcuBrServis = stokOlcuBrServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKOLCUBRListe()
        {
            try
            {
                var data = _stokOlcuBrServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKOLCUBRListe2([FromQuery] string query)
        {
            try
            {
                _adostokOlcuBrServis.HepsiniGetir(query);

                return Ok(_adostokOlcuBrServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKOLCUBREkleyadaGuncelle(PocoSTOKOLCUBR pModel)
        {
            try
            {
                var data = _stokOlcuBrServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKOLCUBRSil(List<PocoSTOKOLCUBR> pModel)
        {
            try
            {
                var data = _stokOlcuBrServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKOLCUBRGuncelle(PocoSTOKOLCUBR pModel)
        {
            try
            {
                var data = _stokOlcuBrServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DeleteById([FromQuery] int id)
        {
            try
            {
                bool succes = _stokOlcuBrServis.DeleteById(id);
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
