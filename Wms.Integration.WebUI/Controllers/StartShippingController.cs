using Microsoft.AspNetCore.Mvc;

namespace Wms.Integration.WebUI.Controllers
{
    public class StartShippingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Index(int Id)
        {
            return View();
            //return View(await ApiHelper.GetListAsync<Slip>("Slip/GetList?StateId=3"));
        }
    }
}
