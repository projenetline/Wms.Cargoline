using Microsoft.AspNetCore.Mvc;

namespace Wms.Integration.UI.Controllers
{
    public class TagListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
