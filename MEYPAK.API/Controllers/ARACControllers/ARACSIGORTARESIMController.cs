using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.ARAC;
using MEYPAK.Entity.PocoModels.ARAC;
using MEYPAK.Interfaces.Arac;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.ARACControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ARACSIGORTARESIMController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAracSigortaResimServis _aracSigortaResimServis;
        private MPAdoContext<MPARACSIGORTARESIM> _adoaracSigortaResimServis = new MPAdoContext<MPARACSIGORTARESIM>();
        public ARACSIGORTARESIMController(IMapper mapper, IAracSigortaResimServis aracSigortaResimServis)
        {
            _mapper = mapper;
            _aracSigortaResimServis = aracSigortaResimServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult ARACSIGORTARESIMListe()
        {
            try
            {
                var data = _aracSigortaResimServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult ARACSIGORTARESIMListe2([FromQuery] string query)
        {
            try
            {
                _adoaracSigortaResimServis.HepsiniGetir(query);
                return Ok(_adoaracSigortaResimServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACSIGORTARESIMEkleyadaGuncelle(PocoARACSIGORTARESIM pModel)
        {
            try
            {
                var data = _aracSigortaResimServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACSIGORTARESIMSil(List<PocoARACSIGORTARESIM> pModel)
        {
            try
            {
                var data = _aracSigortaResimServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACRSIGORTAESIMGuncelle(PocoARACSIGORTARESIM pModel)
        {
            try
            {
                var data = _aracSigortaResimServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpDelete]
        [Route("/[controller]/[action]")]
        public IActionResult DeleteById([FromQuery] int id)
        {
            try
            {
                bool succes = _aracSigortaResimServis.DeleteById(id);
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
