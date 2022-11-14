using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.CARI;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Interfaces.Cari;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.CARIControllers
{
    public class CARIRESIMController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICariResimServis _cariResimServis;
        private MPAdoContext<MPCARIRESIM> _adocariServis = new MPAdoContext<MPCARIRESIM>();
        public CARIRESIMController(IMapper mapper, ICariResimServis cariResimServis)
        {
            _mapper = mapper;
            _cariResimServis = cariResimServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult CARIRESIMListe()
        {
            try
            {
                var data = _cariResimServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult CARIRESIMListe2([FromQuery] string query)
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
        public IActionResult CARIRESIMEkleyadaGuncelle([FromBody]PocoCARIRESIM pModel)
        {
            try
            {
                var data = _cariResimServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult CARIRESIMSil(List<PocoCARIRESIM> pModel)
        {
            try
            {
                var data = _cariResimServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult CARIRESIMGuncelle(PocoCARIRESIM pModel)
        {
            try
            {
                var data = _cariResimServis.Guncelle(pModel);
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
                bool succes = _cariResimServis.DeleteById(id);
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
