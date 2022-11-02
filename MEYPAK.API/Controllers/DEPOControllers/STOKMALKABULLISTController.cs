using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.DEPOControllers
{
    [ApiController]
    [Route("[controller]")]
    public class STOKMALKABULLISTController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStokMalKabulListServis _stokMalKabulListServis;
        private MPAdoContext<MPSTOKMALKABULLIST> _adostokMalKabulListServis = new MPAdoContext<MPSTOKMALKABULLIST>();
        public STOKMALKABULLISTController(IMapper mapper, IStokMalKabulListServis stokMalKabulListServis)
        {
            _mapper = mapper;
            _stokMalKabulListServis = stokMalKabulListServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMALKABULLISTListe()
        {
            try
            {
                var data = _stokMalKabulListServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMALKABULLISTListe2([FromQuery] string query)
        {
            try
            {
                _adostokMalKabulListServis.HepsiniGetir(query);
                return Ok(_adostokMalKabulListServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMALKABULLISTEkleyadaGuncelle(PocoSTOKMALKABULLIST pModel)
        {
            try
            {
                var data = _stokMalKabulListServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMALKABULLISTSil(List<PocoSTOKMALKABULLIST> pModel)
        {
            try
            {
                var data = _stokMalKabulListServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKMALKABULLISTGuncelle(PocoSTOKMALKABULLIST pModel)
        {
            try
            {
                var data = _stokMalKabulListServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DeleteById([FromBody] int id)
        {
            try
            {
                bool succes = _stokMalKabulListServis.DeleteById(id);
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
