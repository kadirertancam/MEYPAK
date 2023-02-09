using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.STOK;
using MEYPAK.Entity.PocoModels.STOK;
using MEYPAK.Interfaces.Hizmet;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.STOKControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class HIZMETKATEGORIController : Controller
    {

        private readonly IHizmetKategoriServis _hizmetKategoriServis;
        private readonly IMapper _mapper;
        private MPAdoContext<MPHIZMET> _adohizmetServis = new MPAdoContext<MPHIZMET>();
        public HIZMETKATEGORIController(IHizmetKategoriServis hizmetServis, IMapper mapper)
        {
            _hizmetKategoriServis = hizmetServis;
            _mapper = mapper;
        }
     

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult HIZMETKATEGORIListe()
        {
            try
            {
                var data = _hizmetKategoriServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult HIZMETKATEGORIListe2([FromQuery] string query)
        {
            try
            {
                _adohizmetServis.HepsiniGetir(query);

                return Ok(_adohizmetServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult HIZMETKATEGORIEkleyadaGuncelle(PocoHIZMETKATEGORI pModel)
        {
            try
            {
                var data = _hizmetKategoriServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult HIZMETKATEGORISil(List<PocoHIZMETKATEGORI> pModel)
        {
            try
            {
                var data = _hizmetKategoriServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult HIZMETKATEGORIGuncelle(PocoHIZMETKATEGORI pModel)
        {
            try
            {
                var data = _hizmetKategoriServis.Guncelle(pModel);
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
                bool succes = _hizmetKategoriServis.DeleteById(id);
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
