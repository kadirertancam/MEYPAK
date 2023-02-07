using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class STOKKASAMARKAController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStokKasaMarkaServis _stokKasaMarkaServis;
        private MPAdoContext<PocoSTOKKASAMARKA> _adostokKasaMarkaServis = new MPAdoContext<PocoSTOKKASAMARKA>();
        public STOKKASAMARKAController(IMapper mapper, IStokKasaMarkaServis stokKasaMarkaServis)
        {
            _mapper = mapper;
            _stokKasaMarkaServis = stokKasaMarkaServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKASAMARKAListe()
        {
            try
            {
                var data = _stokKasaMarkaServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKASAMARKAListe2([FromQuery] string query)
        {
            try
            {
                _adostokKasaMarkaServis.HepsiniGetir(query);

                return Ok(_adostokKasaMarkaServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKASAMARKAEkleyadaGuncelle([FromBody]PocoSTOKKASAMARKA pModel)
        {
            try
            {
                var data = _stokKasaMarkaServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKASAMARKASil(List<PocoSTOKKASAMARKA> pModel)
        {
            try
            {
                var data = _stokKasaMarkaServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKKASAMARKAGuncelle(PocoSTOKKASAMARKA pModel)
        {
            try
            {
                var data = _stokKasaMarkaServis.Guncelle(pModel);
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
                bool succes = _stokKasaMarkaServis.DeleteById(id);
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
