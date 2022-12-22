using Microsoft.AspNetCore.Mvc;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.UI.Controllers
{
    public class TagListController : Controller
    {
        private static IList<CTag> etiketListesi= new List<CTag>{
                 new CTag { Id = Guid.NewGuid(), ArpCode = "Code1", Title = "Cari Unvan 1", Country = "İstanbul", Address1 = "Küçükçekmece", Address2 = "Beylikdüzü", Date = DateTime.Now, Carrier = new Carrier { Description = "Taşıyıcı 1" }, Desi = 51, DocumentNumber = "DOC 1", PackageAmount = 50, PaletShippingChange = true, Palette = 52, Printer = new SysPrinter { Id = 54 }, ShippingDate = DateTime.Now, SlipAmount = 55, TagAmount = 56 },
                 new CTag { Id = Guid.NewGuid(), ArpCode = "Code2", Title = "Cari Unvan 2", Country = "Ankara", Address1 = "Keçiören", Address2 = "Ulus", Date = DateTime.Now, Carrier = new Carrier { Description = "Taşıyıcı 2" }, Desi = 41, DocumentNumber = "DOC 2", PackageAmount = 40, PaletShippingChange = true, Palette = 42, Printer = new SysPrinter { Id = 44 }, ShippingDate = DateTime.Now, SlipAmount = 45, TagAmount = 46 },
                 new CTag { Id = Guid.NewGuid(), ArpCode = "Code3", Title = "Cari Unvan 3", Country = "İzmir", Address1 = "Kazlıbahçe", Address2 = "Bornova", Date = DateTime.Now, Carrier = new Carrier { Description = "Taşıyıcı 2" }, Desi = 31, DocumentNumber = "DOC 2", PackageAmount = 30, PaletShippingChange = true, Palette = 32, Printer = new SysPrinter { Id = 34 }, ShippingDate = DateTime.Now, SlipAmount = 35, TagAmount = 36 }
            };
        [HttpGet]
        public IActionResult Index()
        {
            return View(etiketListesi.AsQueryable());
        }
    }
}
