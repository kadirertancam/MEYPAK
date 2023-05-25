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
    public class ARACMODELController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAracModelServis _aracmodelServis;
        private MPAdoContext<MPARACMODEL> _adoaracmodelServis = new MPAdoContext<MPARACMODEL>();
        public ARACMODELController(IMapper mapper, IAracModelServis aracmodelServis)
        {
            _mapper = mapper;
            _aracmodelServis = aracmodelServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult ARACMODELListe()
        {
            try
            {
                var data = _aracmodelServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult ARACMODELListe2([FromQuery] string query)
        {
            try
            {
                _adoaracmodelServis.HepsiniGetir(query);
                return Ok(_adoaracmodelServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
  
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACMODELSil(List<PocoARACMODEL> pModel)
        {
            try
            {
                var data = _aracmodelServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult ARACMODELGuncelle(PocoARACMODEL pModel)
        {
            try
            {
                var data = _aracmodelServis.Guncelle(pModel);
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
                bool succes = _aracmodelServis.DeleteById(id);
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
