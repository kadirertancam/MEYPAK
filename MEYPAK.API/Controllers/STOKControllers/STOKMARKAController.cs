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
    public class STOKMARKAController : Controller
    {
        private readonly IStokMarkaServis _stokMarkaServis;
        private readonly IMapper _mapper;
        private MPAdoContext<MPSTOKMARKA> _adostokMarkaServis = new MPAdoContext<MPSTOKMARKA>();
        public STOKMARKAController(IStokMarkaServis stokMarkaServis, IMapper mapper)
        {
            _stokMarkaServis = stokMarkaServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMARKAListe()
        {
            try
            {
                var data = _stokMarkaServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMARKAListe2([FromQuery] string query)
        {
            try
            {
                _adostokMarkaServis.HepsiniGetir(query);

                return Ok(_adostokMarkaServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMARKAEkleyadaGuncelle(PocoSTOKMARKA pModel)
        {
            try
            {
                var data = _stokMarkaServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMARKASil(List<PocoSTOKMARKA> pModel)
        {
            try
            {
                var data = _stokMarkaServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMARKAGuncelle(PocoSTOKMARKA pModel)
        {
            try
            {
                var data = _stokMarkaServis.Guncelle(pModel);
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
                bool succes = _stokMarkaServis.DeleteById(id);
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
