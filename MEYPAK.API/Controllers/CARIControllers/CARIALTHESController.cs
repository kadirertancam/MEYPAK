using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Interfaces.Cari;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.CARIControllers
{
    [ApiController]
    [Route("[controller]")]
    public class CARIALTHESController : Controller
    {

        private readonly IMapper _mapper;
        private readonly ICariAltHesServis _cariAltHesServis;
        private MPAdoContext<MPCARIALTHES> _adocariAltHesServis = new MPAdoContext<MPCARIALTHES>();

        public CARIALTHESController(IMapper mapper, ICariAltHesServis cariAltHesServis, MPAdoContext<MPCARIALTHES> adocariAltHesServis)
        {
            _mapper = mapper;
            _cariAltHesServis = cariAltHesServis;
            _adocariAltHesServis = adocariAltHesServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult CARIALTHESListe()
        {
            try
            {
                var data = _cariAltHesServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult CARIALTHESListe2([FromQuery] string query)
        {
            try
            {
                _adocariAltHesServis.HepsiniGetir(query);
                return Ok(_adocariAltHesServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult CARIALTHESEkleyadaGuncelle(PocoCARIALTHES pModel)
        {
            try
            {
                var data = _cariAltHesServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult CARIALTHESSil(List<PocoCARIALTHES> pModel)
        {
            try
            {
                var data = _cariAltHesServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult CARIALTHESGuncelle(PocoCARIALTHES pModel)
        {
            try
            {
                var data = _cariAltHesServis.Guncelle(pModel);
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
                bool succes = _cariAltHesServis.DeleteById(id);
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
