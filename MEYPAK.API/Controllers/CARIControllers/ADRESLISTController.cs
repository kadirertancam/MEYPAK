using AutoMapper;
using MEYPAK.Entity.PocoModels.CARI;
using MEYPAK.Entity.PocoModels.DEPO;
using MEYPAK.Interfaces.Cari;
using MEYPAK.Interfaces.Depo;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.CARIControllers
{
    [ApiController]
    [Route("[controller]")]
    public class ADRESLISTController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAdresListServis _adresListServis;

        public ADRESLISTController(IMapper mapper, IAdresListServis ADRESLISTServis)
        {
            _mapper = mapper;
            _adresListServis = ADRESLISTServis;
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult ADRESLISTListe()
        {
            try
            {
                var data = _adresListServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
       

       
        
    }
}
