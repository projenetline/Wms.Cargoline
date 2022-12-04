using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Wms.Integration.UI.Models;

namespace Wms.Integration.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult DashBoard()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Block()
        {
            return View();
        }
        public IActionResult Decomposition()
        {
            return View();  
        }
        public IActionResult StartShipping()
        {
            return View();
        }
        public IActionResult ShippingList()
        {
            return View();
        }
        public IActionResult TagEdit()
        {

            return View();
        }
        public IActionResult TagList()
        {
            return View();
        }
        public IActionResult Shelf()
        {
            return View();
        }
        public IActionResult ToReturn()
        {
            return View();
        }
        public IActionResult DETER()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}