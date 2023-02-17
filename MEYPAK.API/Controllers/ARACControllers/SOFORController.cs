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
    public class SOFORController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISoforServis _soforServis;
        private MPAdoContext<MPSOFOR> _adosoforServis = new MPAdoContext<MPSOFOR>();
        public SOFORController(IMapper mapper, ISoforServis soforServis)
        {
            _mapper = mapper;
            _soforServis = soforServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult SOFORListe()
        {
            try
            {
                var data = _soforServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult SOFORListe2([FromQuery] string query)
        {
            try
            {
                _adosoforServis.HepsiniGetir(query);
                return Ok(_adosoforServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SOFOREkleyadaGuncelle(PocoSOFOR pModel)
        {
            try
            {
                var data = _soforServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SOFORSil(List<PocoSOFOR> pModel)
        {
            try
            {
                var data = _soforServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SOFORGuncelle(PocoSOFOR pModel)
        {
            try
            {
                var data = _soforServis.Guncelle(pModel);
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
                bool succes = _soforServis.DeleteById(id);
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
