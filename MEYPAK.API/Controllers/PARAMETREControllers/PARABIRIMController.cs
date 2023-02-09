using AutoMapper;
using MEYPAK.DAL.Concrete.ADONET;
using MEYPAK.Entity.Models.PARAMETRE;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Interfaces.Cari;
using MEYPAK.Interfaces.Parametre;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.PARAMETREControllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class PARABIRIMCONTROLLER : Controller
    {
        private readonly IMapper _mapper;
        private readonly IParaBirimServis paraBirimServis;
        private MPAdoContext<MPPARABIRIM> _adoparaBirimServis;
        public PARABIRIMCONTROLLER(IMapper mapper, IParaBirimServis cariServis)
        {
            _mapper = mapper;
            paraBirimServis = cariServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]

        public IActionResult PARABIRIMListe()
        {
            try
            {
                var data = paraBirimServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult PARABIRIMListe2([FromQuery] string query)
        {
            try
            {
                _adoparaBirimServis.HepsiniGetir(query);
                return Ok(_adoparaBirimServis.GenericList);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult PARABIRIMEkleyadaGuncelle(PocoPARABIRIM pModel)
        {
            try
            {
                var data = paraBirimServis.EkleyadaGuncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu! " + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult PARABIRIMSil(List<PocoPARABIRIM> pModel)
        {
            try
            {
                var data = paraBirimServis.Sil(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult PARABIRIMGuncelle(PocoPARABIRIM pModel)
        {
            try
            {
                var data = paraBirimServis.Guncelle(pModel);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }

    }
}
