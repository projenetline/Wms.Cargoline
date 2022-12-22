using Microsoft.AspNetCore.Mvc;

namespace Wms.Integration.UI.Controllers
{
    public class StartShippingController : Controller
    {
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Index( int id)
        {
            if(id== 0)
            {

            }
            else
            {

            }
            //Api GetId=3;
            return View();
        }
        [HttpPost]
        public IActionResult BarcodeRead()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShippingClose()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CustomShipping()
        {
            return View();
        }
        //public async Task<IActionResult> Index(int Id)
        //{
        //    return View();
        //    //return View(await ApiHelper.GetListAsync<Slip>("Slip/GetList?StateId=3"));
        //}
    }
}
