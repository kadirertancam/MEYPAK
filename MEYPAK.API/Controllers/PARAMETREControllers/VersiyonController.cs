using AutoMapper;
using MEYPAK.Interfaces.Parametre;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.PARAMETREControllers
{
    [ApiController]
    [Route("[controller]")]
    public class VersiyonController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IVersionServis _versionServis;
        public VersiyonController(IMapper mapper, IVersionServis versionServis)
        {
            _mapper= mapper;
            _versionServis= versionServis;  
        }
        [HttpGet]
        [Route("/[controller]/[action]")]
        public IActionResult Index()
        {
            try
            {
               var data= _versionServis.Listele();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Problem("Belirsiz bir hata oluştu!" + ex.Message);
            }
        }
    }
}
