using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.PocoModels.FORMYETKI;
using MEYPAK.Interfaces.FormYetki;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.FORMYETKIControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class FORMYETKIController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFormYetkiServis _kasaServis;
        private MPAdoContext<MPFORMYETKI> _adokasaservis = new MPAdoContext<MPFORMYETKI>();
        public FORMYETKIController(IMapper mapper, IFormYetkiServis kasaServis)
        {
            _mapper = mapper;
            _kasaServis = kasaServis;
        }


        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult Liste()
        {
            try
            {
                var data = _kasaServis.Listele();
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
                _adokasaservis.HepsiniGetir(query);

                return Ok(_adokasaservis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }


        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult EkleyadaGuncelle(PocoFORMYETKI pModel)
        {
            try
            {
                var data = _kasaServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Sil(List<PocoFORMYETKI> pModel)
        {
            try
            {
                var data = _kasaServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Guncelle(PocoFORMYETKI pModel)
        {
            try
            {
                var data = _kasaServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DeleteById([FromQuery] string id)
        {
            try
            {
                bool succes = _kasaServis.DeleteById(Convert.ToInt32(id));
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
