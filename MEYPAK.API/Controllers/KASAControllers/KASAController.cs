using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.KASA;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.KASA;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Kasa;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.KASAControllers
{
    [ApiController]
    [Route("[controller]")]
    public class KASAController : Controller
    {

        private readonly IMapper _mapper;
        private readonly IKasaServis _kasaServis;
        private MPAdoContext<MPKASA> _adokasaservis = new MPAdoContext<MPKASA>();
        public KASAController(IMapper mapper, IKasaServis kasaServis)
        {
            _mapper = mapper;
            _kasaServis = kasaServis;
        }


        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult KASAListe()
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
        public IActionResult KASAListe2([FromQuery] string query)
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
        public IActionResult KASAEkleyadaGuncelle(PocoKASA pModel)
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
        public IActionResult KASASil(List<PocoKASA> pModel)
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
        public IActionResult KASAGuncelle(PocoKASA pModel)
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
