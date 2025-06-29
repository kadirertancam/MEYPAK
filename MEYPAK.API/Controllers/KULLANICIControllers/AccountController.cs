﻿using MEYPAK.Entity.IdentityModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MEYPAK.API.Controllers.KULLANICIControllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<MPUSER> _userManager;
        private readonly RoleManager<MPROLE> _roleManager;
        private readonly SignInManager<MPUSER> _signManager;



        public AccountController(UserManager<MPUSER> userManager, RoleManager<MPROLE> roleManager, SignInManager<MPUSER> signManager)
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
                return Ok(user);
            }
            catch (Exception ex)
            {
                return Problem("Beklenmedik bir hata oldu - " + ex.Message, null, 200);
            }
        }

        [HttpGet]

        [Route("/[controller]/[action]")]
        public IActionResult Logout()
        {
            _signManager.SignOutAsync();
            return Ok();
        }


        [HttpPost]
        [Route("/[controller]/[action]")]
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
                    Id = Guid.NewGuid().ToString(),
                    Email = model.Email,
                    EmailConfirmed = true,
                    TwoFactorEnabled = false,
                    UserName = model.UserName,
                    AD = model.Ad,
                    SOYAD = model.Soyad,
                    PhoneNumber = model.Telefon
                };
                var result = _userManager.CreateAsync(user, model.Password).Result;

                return Ok(result.Succeeded ? "Başarıyla Kayıt Oluşturuldu" : "Kayıt Edilemedi");

            }
            catch (Exception ex)
            {
                ViewBag.RegisterFailedMessage = "Beklenmedik bir hata oluştu! " + ex.Message;
                return View(model);
            }
        }
    }
}
