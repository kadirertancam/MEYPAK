using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.PERSONEL;
using MEYPAK.Entity.PocoModels.PERSONEL;
using MEYPAK.Interfaces.Personel;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.PERSONELControllers
{
    public class PERSONELZIMMETController : Controller
    {
        private readonly IPersonelZimmetServis _personelZimmetServis;
        private readonly IMapper _mapper;
        private MPAdoContext<MPPERSONELZIMMET> _adopersonelZimmetServis = new MPAdoContext<MPPERSONELZIMMET>();

        public PERSONELZIMMETController(IPersonelZimmetServis personelZimmetServis, IMapper mapper)
        {
            _personelZimmetServis = personelZimmetServis;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELZIMMETListe()
        {
            try
            {
                var data = _personelZimmetServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELZIMMETListe2([FromQuery] string query)
        {
            try
            {
                _adopersonelZimmetServis.HepsiniGetir(query);
                return Ok(_adopersonelZimmetServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELZIMMETEkleyadaGuncelle(PocoPERSONELZIMMET pModel)
        {
            try
            {
                var data = _personelZimmetServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELZIMMETSil(List<PocoPERSONELZIMMET> pModel)
        {
            try
            {
                var data = _personelZimmetServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult PERSONELZIMMETGuncelle(PocoPERSONELZIMMET pModel)
        {
            try
            {
                var data = _personelZimmetServis.Guncelle(pModel);
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
                bool succes = _personelZimmetServis.DeleteById(id);
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
