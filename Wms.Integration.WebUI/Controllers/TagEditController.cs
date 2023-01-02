using Microsoft.AspNetCore.Mvc;

namespace Wms.Integration.WebUI.Controllers
{
    public class TagEditController : Controller
    {
        [HttpGet]
        public IActionResult Index(Guid id)
        {
            if(id==Guid.Empty)
            {

            }
            else
            {

            }
            return View();
        }
    }
}
