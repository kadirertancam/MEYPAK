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
    public class HKSILCELERController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IHksIlcelerServis _HksIlcelerServis;
        private MPAdoContext<MPHKSILCELER> _adocariServis = new MPAdoContext<MPHKSILCELER>();
        public HKSILCELERController(IMapper mapper, IHksIlcelerServis HksIlcelerServis)
        {
            _mapper = mapper;
            _HksIlcelerServis = HksIlcelerServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult HksIlcelerListe()
        {
            try
            {
                var data = _HksIlcelerServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult HksIlcelerListe2([FromQuery] string query)
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
        public IActionResult HksIlcelerEkleyadaGuncelle([FromBody] PocoHKSILCELER pModel)
        {
            try
            {
                var data = _HksIlcelerServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult HksIlcelerSil(List<PocoHKSILCELER> pModel)
        {
            try
            {
                var data = _HksIlcelerServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult HksIlcelerGuncelle(PocoHKSILCELER pModel)
        {
            try
            {
                var data = _HksIlcelerServis.Guncelle(pModel);
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
                bool succes = _HksIlcelerServis.DeleteById(id);
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
