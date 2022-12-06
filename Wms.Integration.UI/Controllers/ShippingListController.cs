using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.UI.Controllers
{
    public class ShippingListController : Controller
    {
        private static IList<Slip> slipList=new List<Slip>{
                new Slip { Id = 1, SlipDate = DateTime.Now,DocumentNumber="DOC1", SlipNumber = "S111111", Arp = new Arp { Title = "Mehmet", Code = "Code1" } },
                new Slip { Id = 2, SlipDate = DateTime.Now, DocumentNumber = "DOC2", SlipNumber = "S222222", Arp = new Arp { Title = "Ahmet", Code = "Code2" } },
                new Slip { Id = 3, SlipDate = DateTime.Now, DocumentNumber = "DOC3", SlipNumber = "S333333", Arp = new Arp { Title = "Dİlan", Code = "Code2" } }
            };
        public IActionResult Index()
        {
            return View(slipList.AsQueryable());
        }
    }
}
