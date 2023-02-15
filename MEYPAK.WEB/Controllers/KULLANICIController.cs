using MEYPAK.BLL.Assets;
using MEYPAK.Entity.IdentityModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.WEB.Controllers
{
    [Route("[controller]")]
    public class KULLANICIController : Controller
    {
        GenericWebServis<LoginModel> _loginService = new GenericWebServis<LoginModel>();
        

        public KULLANICIController()
        {
         
        }
        [HttpGet]
     
        [Route("/[controller]/[action]")]
        public IActionResult Index()
        {
            return Ok("Sisteme Giriş Yapıldı.");
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        public IActionResult Login(string Email,string Password)
        {

            try
            {
                _loginService.Data(ServisList.UserLoginServis, new LoginModel()
                {
                    Email = Email,
                    Password = Password,
                    RememberMe = true,
                });

                if (_loginService.loginResult != null)
                {
                    return RedirectToAction("Home", "Default");
                }
                else
                    return RedirectToAction("Index", "Default");

            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Default");
            }
       
        }

       

    }
}
