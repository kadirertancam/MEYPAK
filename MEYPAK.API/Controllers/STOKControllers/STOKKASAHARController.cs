using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.KASA;
using MEYPAK.Entity.PocoModels.KASA;
using MEYPAK.Interfaces.Kasa;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    [ApiController]
    [Route("[controller]")]
    public class KASAHARController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IKasaServis _kasaHarServis;
        private MPAdoContext<MPKASA> _adokasaHarservis = new MPAdoContext<MPKASA>();
        public KASAHARController(IMapper mapper, IKasaServis kasaHarServis)
        {
            _mapper = mapper;
            _kasaHarServis = kasaHarServis;
        }


        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult KASAHARListe()
        {
            try
            {
                var data = _kasaHarServis.Listele();
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
                _adokasaHarservis.HepsiniGetir(query);

                return Ok(_adokasaHarservis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }


        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult KASAEHARkleyadaGuncelle(PocoKASA pModel)
        {
            try
            {
                var data = _kasaHarServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult KASAHARSil(List<PocoKASA> pModel)
        {
            try
            {
                var data = _kasaHarServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult KASAHARGuncelle(PocoKASA pModel)
        {
            try
            {
                var data = _kasaHarServis.Guncelle(pModel);
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
                bool succes = _kasaHarServis.DeleteById(Convert.ToInt32(id));
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
