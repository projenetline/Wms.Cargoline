using Microsoft.AspNetCore.Mvc;

namespace Wms.Integration.WebUI.Controllers
{
    public class ShippingListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
