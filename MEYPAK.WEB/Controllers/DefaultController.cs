using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.WEB.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
