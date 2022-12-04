using Microsoft.AspNetCore.Mvc;

namespace Wms.Integration.WebUI.Controllers
{
    public class TagListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
