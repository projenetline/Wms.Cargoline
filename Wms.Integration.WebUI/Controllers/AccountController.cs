using Microsoft.AspNetCore.Mvc;

namespace Wms.Integration.WebUI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
