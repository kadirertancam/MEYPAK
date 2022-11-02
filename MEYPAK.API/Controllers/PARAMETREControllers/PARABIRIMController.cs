using AutoMapper;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.PARAMETRE;
using MEYPAK.Interfaces.Cari;
using MEYPAK.Interfaces.Parametre;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.PARAMETREControllers
{
    [ApiController]
    [Route("[controller]")]
    public class PARABIRIMCONTROLLER : Controller
    {
        private readonly IMapper _mapper;
        private readonly IParaBirimServis paraBirimServis;

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
