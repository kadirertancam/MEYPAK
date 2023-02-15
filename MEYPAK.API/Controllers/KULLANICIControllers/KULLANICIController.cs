using MEYPAK.Entity.IdentityModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.KULLANICIControllers
{
    [ApiController]
    [Route("[controller]")]
    public class KULLANICIController : Controller
    {
        private readonly UserManager<MPUSER> _userManager;
        private readonly RoleManager<MPROLE> _roleManager;
        private readonly SignInManager<MPUSER> _signManager;
        
        

        public KULLANICIController(UserManager<MPUSER> userManager, RoleManager<MPROLE> roleManager, SignInManager<MPUSER> signManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signManager = signManager;
        }

        [HttpGet]
        [Authorize]
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
                if (!ModelState.IsValid)
                {
                    return Problem("Giriş bilgilerini eksiksiz doldurunuz.");
                }
                var user = _userManager.FindByEmailAsync(model.Email).Result;

                if (user == null)
                {
                    return Problem("Sistemde kullanıcı bilgisi bulunamadı.");
                }
                var result = _signManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false).Result;
                if (result.Succeeded)
                {
                    LoginResultModel resultModel = new LoginResultModel() { 
                    MPUSER=user,
                    userRoles = _userManager.GetRolesAsync(user).Result as List<string>
                    };
                 
                    return Ok(resultModel);
                }
                return Problem("Giriş Yapılamadı!");
               
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oldu - " + ex.Message, null, 200);
            }
        }

        [HttpGet]
        [Route("/[controller]/[action]")]
        [Authorize]
        public IActionResult Logout()
        {
            _signManager.SignOutAsync();
            return Ok();
        }


        [HttpPost]
        [Route("/[controller]/[action]")]
        [Authorize]
        public IActionResult Register(RegisterModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                var checkEmail = _userManager.FindByEmailAsync(model.Email).Result;
                if (checkEmail != null)
                {
                    return Ok("HATA! Bu email sisteme zaten kayıtlıdır!");
                }
                MPUSER user = new MPUSER()
                {
                    Id= Guid.NewGuid().ToString(),
                    Email = model.Email,
                    EmailConfirmed = true,
                    TwoFactorEnabled= false,
                    UserName = model.Email,
                    AD=model.Ad,
                    SOYAD=model.Soyad,
                    PhoneNumber = model.Telefon
                };
                var result = _userManager.CreateAsync(user, model.Password).Result;
                return Ok(result.Succeeded?"Başarıyla Kayıt Oluşturuldu":"Kayıt Edilemedi");

            }
            catch (Exception ex)
            {
                ViewBag.RegisterFailedMessage = "Beklenmedik bir hata oluştu! " + ex.Message;
                return View(model);
            }
        }


        [HttpPost]
        [Route("/[controller]/[action]")]
        [Authorize]
        public async Task<IActionResult> RolVer(LoginResultModel result)
        {
           
            foreach (string role in result.userRoles)
            {
                if (_roleManager.RoleExistsAsync(role).Result)
                 await _userManager.AddToRoleAsync(_userManager.FindByEmailAsync(result.MPUSER.Email).Result, role);
            }
            return Ok();
        }

        [HttpPost]
        [Route("/[controller]/[action]")]
        [Authorize]
        public IActionResult RolleriOlustur()
        {
            string[] allRoles = Enum.GetNames(typeof(AllRoles));
            foreach (string role in allRoles)
            {
                if (!_roleManager.RoleExistsAsync(role).Result)
                {
                    //eğer o rol yoksa ekle
                    MPROLE r = new MPROLE()
                    {
                        Id= Guid.NewGuid().ToString(),
                        Name = role,
                        ACIKLAMA="Otomatik Olusturma",
                        OLUSTURMATARIHI = DateTime.Now,
                        GUNCELLEMETARIHI = DateTime.Now,
                    };
                    var result = _roleManager.CreateAsync(r).Result;
                }
            }
            return Ok();
        }
        [HttpPost]
        [Route("/[controller]/[action]")]
        [Authorize(Roles = "ADMIN")]
        public IActionResult USERGET()
        {
            var a = _userManager.Users;
            return Ok(a);
        }

    }
}
