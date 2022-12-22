using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Wms.Integration.DataAccess.Concrete.Contexts;

namespace Wms.Integration.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        public AccountController (SignInManager<ApplicationUser> signInManager)
        {
            this.signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(ApplicationUser user)
        {
            Microsoft.AspNetCore.Identity.SignInResult result;
            if (ModelState.IsValid)
            {
                result = await signInManager.PasswordSignInAsync(user.UserName, user.Password, true, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            return View();
        }
    }
}
