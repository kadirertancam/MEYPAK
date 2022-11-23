using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.KASA;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.KASA;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Kasa;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    [ApiController]
    [Route("[controller]")]
    public class KASAHARController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStokKasaHarServis _kasaHarServis;
        private MPAdoContext<MPSTOKKASAHAR> _adokasaHarservis = new MPAdoContext<MPSTOKKASAHAR>();
        public KASAHARController(IMapper mapper, IStokKasaHarServis kasaHarServis)
        {
            _mapper = mapper;
            _kasaHarServis = kasaHarServis;
        }


        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKASAHARListe()
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
        public IActionResult STOKKASAHARListe2([FromQuery] string query)
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
        public IActionResult STOKKASAHAREkleyadaGuncelle(PocoSTOKKASAHAR pModel)
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
        public IActionResult STOKKASAHARSil(List<PocoSTOKKASAHAR> pModel)
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
        public IActionResult STOKKASAHARGuncelle(PocoSTOKKASAHAR pModel)
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
