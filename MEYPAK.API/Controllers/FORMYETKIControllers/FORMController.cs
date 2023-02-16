using AutoMapper;
using MEYPAK.BLL.FORMYETKI;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.FORMYETKI;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Entity.PocoModels.FORMYETKI;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Interfaces.FormYetki;
using MEYPAK.Interfaces.Parametre;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.FORMYETKIControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class FORMController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFormServis _kasaServis;
        private MPAdoContext<MPFORM> _adokasaservis = new MPAdoContext<MPFORM>();
        public FORMController(IMapper mapper, IFormServis kasaServis)
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
        public IActionResult EkleyadaGuncelle(PocoFORM pModel)
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
        public IActionResult Sil(List<PocoFORM> pModel)
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
        public IActionResult Guncelle(PocoFORM pModel)
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
