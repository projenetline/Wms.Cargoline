using Microsoft.AspNetCore.Mvc;

namespace Wms.Integration.WebUI.Components
{
    public class TagEditComp:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
