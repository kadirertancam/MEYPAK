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
    public class STOKFIYATController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStokFiyatServis _stokFiyatServis;
        private MPAdoContext<MPSTOKFIYAT> _adostokfiyatServis = new MPAdoContext<MPSTOKFIYAT>();
        public STOKFIYATController(IMapper mapper, IStokFiyatServis stokFiyatServis)
        {
            _mapper = mapper;
            _stokFiyatServis = stokFiyatServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATListe()
        {
            try
            {
                var data = _stokFiyatServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATListe2([FromQuery] string query)
        {
            try
            {
                _adostokfiyatServis.HepsiniGetir(query);

                return Ok(_adostokfiyatServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATEkleyadaGuncelle(PocoSTOKFIYAT pModel)
        {
            try
            {
                var data = _stokFiyatServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATSil(List<PocoSTOKFIYAT> pModel)
        {
            try
            {
                var data = _stokFiyatServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKFIYATGuncelle(PocoSTOKFIYAT pModel)
        {
            try
            {
                var data = _stokFiyatServis.Guncelle(pModel);
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
                bool succes = _stokFiyatServis.DeleteById(id);
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
