using Microsoft.AspNetCore.Mvc;

namespace Wms.Integration.WebUI.Controllers
{
    public class ToReturnController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
