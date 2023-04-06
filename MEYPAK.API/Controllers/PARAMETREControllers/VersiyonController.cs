using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.PARAMETREControllers
{
    public class VersiyonController : Controller
    {
        public IActionResult Index()
        {
            return Ok("1.2.0.1");
        }
    }
}
