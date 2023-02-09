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
    public class SEVKADRESController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISevkAdresServis _sevkAdresServis;
        private MPAdoContext<MPSEVKADRES> _adocariServis = new MPAdoContext<MPSEVKADRES>();
        public SEVKADRESController(IMapper mapper, ISevkAdresServis sevkAdresServis)
        {
            _mapper = mapper;
            _sevkAdresServis = sevkAdresServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult SEVKADRESListe()
        {
            try
            {
                var data = _sevkAdresServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult SEVKADRESListe2([FromQuery] string query)
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
        public IActionResult SEVKADRESEkleyadaGuncelle([FromBody]PocoSEVKADRES pModel)
        {
            try
            {
                var data = _sevkAdresServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SEVKADRESSil(List<PocoSEVKADRES> pModel)
        {
            try
            {
                var data = _sevkAdresServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult SEVKADRESGuncelle(PocoSEVKADRES pModel)
        {
            try
            {
                var data = _sevkAdresServis.Guncelle(pModel);
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
                bool succes = _sevkAdresServis.DeleteById(id);
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
