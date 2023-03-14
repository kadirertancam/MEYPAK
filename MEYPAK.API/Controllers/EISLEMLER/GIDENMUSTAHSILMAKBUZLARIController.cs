using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.EISLEMLER;
using MEYPAK.Entity.PocoModels.EISLEMLER;
using MEYPAK.Interfaces.EIslemler;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.EISLEMLER
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class GIDENMUSTAHSILMAKBUZLARIController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGidenMustahsilMakbuzlariServis _gidenIrsaliyeServis;
        private MPAdoContext<MPGIDENMUSTAHSILMAKBUZLARI> _adoGIDENIRSALIYELERServis = new MPAdoContext<MPGIDENMUSTAHSILMAKBUZLARI>();
        public GIDENMUSTAHSILMAKBUZLARIController(IMapper mapper, IGidenMustahsilMakbuzlariServis irsaliyeServis)
        {
            _mapper = mapper;
            _gidenIrsaliyeServis = irsaliyeServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult Liste()
        {
            try
            {
                var data = _gidenIrsaliyeServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult Liste2([FromQuery] string query)
        {
            try
            {
                _adoGIDENIRSALIYELERServis.HepsiniGetir(query);
                return Ok(_adoGIDENIRSALIYELERServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult EKleyadaGuncelle(PocoGIDENMUSTAHSILMAKBUZLARI pModel)
        {
            try
            {
                var data = _gidenIrsaliyeServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult GIDENIRSALIYELERSil(List<PocoGIDENMUSTAHSILMAKBUZLARI> pModel)
        {
            try
            {
                var data = _gidenIrsaliyeServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Guncelle(PocoGIDENMUSTAHSILMAKBUZLARI pModel)
        {
            try
            {
                var data = _gidenIrsaliyeServis.Guncelle(pModel);
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
                bool succes = _gidenIrsaliyeServis.DeleteById(id);
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
