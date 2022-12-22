using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wms.Integration.WebUI.Services.Abstract;

namespace Wms.Integration.WebUI.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly IUserAuthenticationService userAuthenticationService;
        public DashboardController(IUserAuthenticationService userAuthenticationService) { this.userAuthenticationService = userAuthenticationService; }

        public  IActionResult Index()
        {
           return View();
        }
    }
}
