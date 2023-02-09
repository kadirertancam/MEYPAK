using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.DEPO;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Depo;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.DEPOControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class DEPOCEKILISTController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IDepoCekiListServis _depoCekiListServis;
        private MPAdoContext<MPDEPOCEKILIST> _adodepoCekiListServis = new MPAdoContext<MPDEPOCEKILIST>();
        public DEPOCEKILISTController(IMapper mapper, IDepoCekiListServis depoCekiListServis)
        {
            _mapper = mapper;
            _depoCekiListServis = depoCekiListServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOCEKILISTListe()
        {
            try
            {
                var data = _depoCekiListServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOCEKILISTListe2([FromQuery] string query)
        {
            try
            {
                _adodepoCekiListServis.HepsiniGetir(query);
                return Ok(_adodepoCekiListServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOCEKILISTEkleyadaGuncelle(PocoDEPOCEKILIST pModel)
        {
            try
            {
                var data = _depoCekiListServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOCEKILISTSil(List<PocoDEPOCEKILIST> pModel)
        {
            try
            {
                var data = _depoCekiListServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult DEPOCEKILISTGuncelle(PocoDEPOCEKILIST pModel)
        {
            try
            {
                var data = _depoCekiListServis.Guncelle(pModel);
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
                bool succes = _depoCekiListServis.DeleteById(id);
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
