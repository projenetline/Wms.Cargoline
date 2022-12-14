using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Wms.Integration.DataAccess.Concrete.Contexts;
using Wms.Integration.WebUI.Models;
using Wms.Integration.WebUI.Services.Abstract;
using Wms.Integration.WebUI.Services.Concrete;

namespace Wms.Integration.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUserAuthenticationService userAuthenticationService;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AdminController(IUserAuthenticationService userAuthenticationService, SignInManager<ApplicationUser> signInManager)
        {
            this.userAuthenticationService = userAuthenticationService;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Login(UserSignInViewModel model)
        {
            if(ModelState.IsValid)
            {
                var result = await userAuthenticationService.LoginAsync(model);
                if (result.Result)
                {
                    return RedirectToAction("Index", "ShippingList");
                }
                else
                {
                    TempData["msg"] = result.Message;
                    return RedirectToAction(nameof(Login));
                }
                
            }
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await userAuthenticationService.LogoutAsync();
            return RedirectToAction(nameof(Login));
        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RememberPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Registration(UserRegistrationViewModel model)
        {
            if(ModelState.IsValid) 
            {
                model.Role = "user";
                var result = await userAuthenticationService.RegistrationAsync(model);
                TempData["msg"] = result.Message;
                return RedirectToAction(nameof(Registration));
              
            }
            return View(model);
        }
        public  async Task<IActionResult> Rec()
        {
            UserRegistrationViewModel model= new UserRegistrationViewModel
            {
                UserName="MD123456",
                Email="mehmet.dogan@netline.net.tr",
                FirstName="Mehmet",
                LastName="Doğan",
                Password="Admin123",
                Role="Admin",
            };
            model.Role= "user";
            var result=await userAuthenticationService.RegistrationAsync(model);
            return Ok(result);
        }



  


    }
}
