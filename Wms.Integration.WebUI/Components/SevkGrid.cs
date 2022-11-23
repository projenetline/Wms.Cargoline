using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace Wms.Integration.WebUI.Components
{
    public class SevkGrid:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
