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
    public class HKSILLERController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IHksIllerServis _HksIllerServis;
        private MPAdoContext<MPHKSILLER> _adocariServis = new MPAdoContext<MPHKSILLER>();

        public HKSILLERController(IMapper mapper, IHksIllerServis HksIllerServis)
        {
            _mapper = mapper;
            _HksIllerServis = HksIllerServis;
        }
        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult HksIllerListe()
        {
            try
            {
                var data = _HksIllerServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult HksIllerListe2([FromQuery] string query)
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
        public IActionResult HksIllerEkleyadaGuncelle([FromBody] PocoHKSILLER pModel)
        {
            try
            {
                var data = _HksIllerServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult HksIllerSil(List<PocoHKSILLER> pModel)
        {
            try
            {
                var data = _HksIllerServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult HksIllerGuncelle(PocoHKSILLER pModel)
        {
            try
            {
                var data = _HksIllerServis.Guncelle(pModel);
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
                bool succes = _HksIllerServis.DeleteById(id);
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
