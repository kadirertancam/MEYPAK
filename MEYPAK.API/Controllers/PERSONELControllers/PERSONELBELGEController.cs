using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Interfaces.Personel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.PERSONELControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class PERSONELBELGEController : Controller
    {
        private readonly IPersonelBelgeServis _personelServis;
        private readonly IMapper _mapper;
        private MPAdoContext<MPPERSONELBELGE> _adopersonelServis = new MPAdoContext<MPPERSONELBELGE>();
        public PERSONELBELGEController(IPersonelBelgeServis personelServis, IMapper mapper)
        {
            _personelServis = personelServis;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult Liste()
        {
            try
            {
                var data = _personelServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult Liste2([FromQuery] string query)
        {
            try
            {
                _adopersonelServis.HepsiniGetir(query);
                return Ok(_adopersonelServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult EkleyadaGuncelle(PocoPERSONELBELGE pModel)
        {
            try
            {
                var data = _personelServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Sil(List<PocoPERSONELBELGE> pModel)
        {
            try
            {
                var data = _personelServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Guncelle(PocoPERSONELBELGE pModel)
        {
            try
            {
                var data = _personelServis.Guncelle(pModel);
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
                bool succes = _personelServis.DeleteById(id);
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
