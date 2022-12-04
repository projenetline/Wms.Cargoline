using Microsoft.AspNetCore.Mvc;

namespace Wms.Integration.UI.Components
{
    public class TagListComp:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
