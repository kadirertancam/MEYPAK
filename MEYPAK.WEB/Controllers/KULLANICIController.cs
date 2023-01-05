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
        public IActionResult Login(LoginModel model)
        {
            try
            {
                _loginService.Data(ServisList.UserLoginServis,model);
                if (model.Email=="admin"&&model.Password=="123")
                {
                    return RedirectToAction("StokKart", "STOK");
                }
               return RedirectToAction("Index","Default");
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oldu - " + ex.Message, null, 200);
            }
        }

       

    }
}
