using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Stok;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    public class STOKRESIMController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStokResimServis _stokResimServis;
        private MPAdoContext<MPSTOKRESIM> _adostokResimServis = new MPAdoContext<MPSTOKRESIM>();
        public STOKRESIMController(IMapper mapper, IStokResimServis stokResimServis)
        {
            _mapper = mapper;
            _stokResimServis = stokResimServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKRESIMListe()
        {
            try
            {
                var data = _stokResimServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult STOKRESIMListe2([FromQuery] string query)
        {
            try
            {
                _adostokResimServis.HepsiniGetir(query);

                return Ok(_adostokResimServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKRESIMEkleyadaGuncelle([FromBody]PocoSTOKRESIM pModel)
        {
            try
            {
                var data = _stokResimServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKRESIMSil(List<PocoSTOKRESIM> pModel)
        {
            try
            {
                var data = _stokResimServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult STOKRESIMGuncelle(PocoSTOKRESIM pModel)
        {
            try
            {
                var data = _stokResimServis.Guncelle(pModel);
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
                bool succes = _stokResimServis.DeleteById(id);
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
