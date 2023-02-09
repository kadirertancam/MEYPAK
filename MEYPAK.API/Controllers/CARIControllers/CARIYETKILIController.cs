using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Interfaces.Cari;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.CARIControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class CARIYETKILIController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICariYetkiliServis _cariYetkiliServis;
        private MPAdoContext<MPCARIYETKILI> _adocariServis = new MPAdoContext<MPCARIYETKILI>();

        public CARIYETKILIController(IMapper mapper, ICariYetkiliServis cariYetkiliServis)
        {
            _mapper = mapper;
            _cariYetkiliServis = cariYetkiliServis;
        }
        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult CARIYETKILIListe()
        {
            try
            {
                var data = _cariYetkiliServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult CARIYETKILIListe2([FromQuery] string query)
        {
            try
            {
                _adocariServis.HepsiniGetir(query);
                return Ok(_adocariServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult CARIYETKILIEkleyadaGuncelle([FromBody] PocoCARIYETKILI pModel)
        {
            try
            {
                var data = _cariYetkiliServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult CARIYETKILISil(List<PocoCARIYETKILI> pModel)
        {
            try
            {
                var data = _cariYetkiliServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult CARIYETKILIGuncelle(PocoCARIYETKILI pModel)
        {
            try
            {
                var data = _cariYetkiliServis.Guncelle(pModel);
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
                bool succes = _cariYetkiliServis.DeleteById(id);
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
