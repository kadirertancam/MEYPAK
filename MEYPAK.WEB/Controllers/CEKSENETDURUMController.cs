using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.WEB.Controllers
{
    public class CEKSENETDURUMController : Controller
    {
        private readonly ILogger<CEKSENETDURUMController> _logger;

        public CEKSENETDURUMController(ILogger<CEKSENETDURUMController> logger)
        {
            _logger = logger;
        }
    
        public IActionResult Index()
        {
            return View();
        }

        public void CekSenetDurumRaporla()
        {
            
        }
    }
}
