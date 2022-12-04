using Microsoft.AspNetCore.Mvc;

namespace Wms.Integration.UI.Controllers
{
    public class ShippingListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
