using Microsoft.AspNetCore.Mvc;

namespace Wms.Integration.UI.Controllers
{
    public class ToReturnController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
