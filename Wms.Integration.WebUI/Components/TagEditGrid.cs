using Microsoft.AspNetCore.Mvc;

namespace Wms.Integration.WebUI.Components
{
    public class TagEditGrid:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
