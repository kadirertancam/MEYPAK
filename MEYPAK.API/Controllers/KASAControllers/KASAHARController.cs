using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.KASA;
using MEYPAK.Entity.PocoModels.KASA;
using MEYPAK.Interfaces.Kasa;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.KASAControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class KASAHARController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IKasaHarServis _kasaServis;
        private MPAdoContext<MPKASAHAR> _adokasaservis = new MPAdoContext<MPKASAHAR>();
        public KASAHARController(IMapper mapper, IKasaHarServis kasaServis)
        {
            _mapper = mapper;
            _kasaServis = kasaServis;
        }


        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult KASAHARListe()
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
        public IActionResult KASAHARListe2([FromQuery] string query)
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
        public IActionResult KASAHAREkleyadaGuncelle(PocoKASAHAR pModel)
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
        public IActionResult KASAHARSil(List<PocoKASAHAR> pModel)
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
        public IActionResult KASAHARGuncelle(PocoKASAHAR pModel)
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
