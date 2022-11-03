using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    [ApiController]
    [Route("[controller]")]
    public class STOKSAYIMController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStokSayimServis _stoksayimServis;
        private MPAdoContext<MPSTOKSAYIM> _adostoksayimServis = new MPAdoContext<MPSTOKSAYIM>();
        public STOKSAYIMController(IMapper mapper, IStokSayimServis stoksayimServis)
        {
            _mapper = mapper;
            _stoksayimServis = stoksayimServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMListe()
        {
            try
            {
                var data = _stoksayimServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMListe2([FromQuery] string query)
        {
            try
            {
                _adostoksayimServis.HepsiniGetir(query);

                return Ok(_adostoksayimServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMEkleyadaGuncelle(PocoSTOKSAYIM pModel)
        {
            try
            {
                var data = _stoksayimServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMSil(List<PocoSTOKSAYIM> pModel)
        {
            try
            {
                var data = _stoksayimServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKSAYIMGuncelle(PocoSTOKSAYIM pModel)
        {
            try
            {
                var data = _stoksayimServis.Guncelle(pModel);
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
                bool succes = _stoksayimServis.DeleteById(id);
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
