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
    public class STOKSEVKIYATLISTController : Controller
    {

        private readonly IMapper _mapper;
        private readonly IStokSevkiyatListServis _stokSevkiyatListServis;
        private MPAdoContext<MPSTOKSEVKİYATLİST> _adostokSevkiyatListServis = new MPAdoContext<MPSTOKSEVKİYATLİST>();
        public STOKSEVKIYATLISTController(IMapper mapper, IStokSevkiyatListServis stokSevkiyatListServis)
        {
            _mapper = mapper;
            _stokSevkiyatListServis = stokSevkiyatListServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSEVKIYATLISTListe()
        {
            try
            {
                var data = _stokSevkiyatListServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSEVKIYATLISTListe2([FromQuery] string query)
        {
            try
            {
                _adostokSevkiyatListServis.HepsiniGetir(query);
                return Ok(_adostokSevkiyatListServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSEVKIYATLISTEkleyadaGuncelle(PocoSTOKSEVKIYATLIST pModel)
        {
            try
            {
                var data = _stokSevkiyatListServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSEVKIYATLISTSil(List<PocoSTOKSEVKIYATLIST> pModel)
        {
            try
            {
                var data = _stokSevkiyatListServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSEVKIYATLISTGuncelle(PocoSTOKSEVKIYATLIST pModel)
        {
            try
            {
                var data = _stokSevkiyatListServis.Guncelle(pModel);
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
                bool succes = _stokSevkiyatListServis.DeleteById(id);
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
