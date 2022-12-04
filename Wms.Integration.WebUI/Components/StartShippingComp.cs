using Microsoft.AspNetCore.Mvc;

namespace Wms.Integration.WebUI.Components
{
    public class StartShippingComp:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
