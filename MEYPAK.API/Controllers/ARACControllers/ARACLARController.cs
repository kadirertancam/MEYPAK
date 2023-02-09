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
    public class ARACLARController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAraclarServis _araclarServis;
        private MPAdoContext<MPARACLAR> _adoaraclarServis = new MPAdoContext<MPARACLAR>();
        public ARACLARController(IMapper mapper, IAraclarServis araclarServis)
        {
            _mapper = mapper;
            _araclarServis = araclarServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult ARACLARListe()
        {
            try
            {
                var data = _araclarServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult ARACLARListe2([FromQuery] string query)
        {
            try
            {
                _adoaraclarServis.HepsiniGetir(query);
                return Ok(_adoaraclarServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACLAREkleyadaGuncelle(PocoARACLAR pModel)
        {
            try
            {
                var data = _araclarServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACLARSil(List<PocoARACLAR> pModel)
        {
            try
            {
                var data = _araclarServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACLARGuncelle(PocoARACLAR pModel)
        {
            try
            {
                var data = _araclarServis.Guncelle(pModel);
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
                bool succes = _araclarServis.DeleteById(id);
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
