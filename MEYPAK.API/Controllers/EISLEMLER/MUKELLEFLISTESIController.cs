using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.EISLEMLER;
using MEYPAK.Entity.PocoModels.EISLEMLER;
using MEYPAK.Interfaces.EIslemler;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MEYPAK.API.Controllers.EISLEMLER
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class MUKELLEFLISTESIController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IMukellefListesiServis _MUKELLEFLISTESIServis;
        private MPAdoContext<MPMUKELLEFLISTESI> _adoMUKELLEFLISTESIServis = new MPAdoContext<MPMUKELLEFLISTESI>();
        private AdoConnect con = new AdoConnect();
        public MUKELLEFLISTESIController(IMapper mapper, IMukellefListesiServis mukellefListesiServis)
        {
            _mapper = mapper;
            _MUKELLEFLISTESIServis = mukellefListesiServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult MUKELLEFLISTESIListe()
        {
            try
            {
                var data = _MUKELLEFLISTESIServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult MUKELLEFLISTESIListe2()
        {
            try
            {
                con.komutgonder("TRUNCATE TABLE MPMUKELLEFLISTESI");
                _adoMUKELLEFLISTESIServis.HepsiniGetir();
                return Ok(_adoMUKELLEFLISTESIServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult MUKELLEFLISTESIEKle(PocoMUKELLEFLISTESI pModel)
        {
            try
            {
               
                var data = _MUKELLEFLISTESIServis.Ekle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult MUKELLEFLISTESISil(List<PocoMUKELLEFLISTESI> pModel)
        {
            try
            {
                var data = _MUKELLEFLISTESIServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult MUKELLEFLISTESIGuncelle(PocoMUKELLEFLISTESI pModel)
        {
            try
            {
                var data = _MUKELLEFLISTESIServis.Guncelle(pModel);
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
                bool succes = _MUKELLEFLISTESIServis.DeleteById(id);
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
