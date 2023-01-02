using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.Shipments;
using Wms.Integration.UI.Helpers;
using Wms.Integration.WebUI.Models;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using Wms.Integration.WebUI.PrintHelper;
using DinkToPdf.Contracts;
using Wms.Integration.Core.DataAccess.Utilities.Results;

namespace Wms.Integration.WebUI.Controllers
{
    public class ShippingListController : Controller
    {


        private IConverter _converter;
        public ShippingListController(IConverter converter)
        {
            _converter = converter;
        }
        public IActionResult Index()
        {

            RawPrintHelper printHelper = new RawPrintHelper();


            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Shipping(List<string> OrderList)
        {
            string[] OrderIdList = OrderList[0].Split(',');


            ResultViewModel result = new ResultViewModel();

            ShippingModel model = new ShippingModel();

            foreach (var item in OrderIdList)
            {

                result = await ApiHelper.GetAsync<ShippingModel>("http://localhost/api/Shipment/GetShippingDetail?OrderId=" + item);

                var resultModel = (ShippingModel)result.Data;

                if (string.IsNullOrEmpty(model.OrderNr))
                {
                    model.OrderIdList.Add(item);
                    model.OrderNr = resultModel.OrderNr;
                    model.Address1 = resultModel.Address1;
                    model.Address2 = resultModel.Address2;
                    model.City = resultModel.City;
                    model.Town = resultModel.Town;
                    model.Date = resultModel.Date;
                    model.Amount = "1";
                    model.ClCode = resultModel.ClCode;
                    model.ClDefintion = resultModel.ClDefintion;
                    foreach (var resItem in resultModel.Items)
                    {
                        model.Items.Add(new ShippingItem()
                        {
                            Barcode = resItem.Barcode,
                            ItemCode = resItem.ItemCode,
                            ItemName = resItem.ItemName,
                            LeftAmount = resItem.LeftAmount,
                            LotNr = resItem.LotNr,
                            OrderAmount = resItem.OrderAmount,
                            Shipped = resItem.Shipped,
                            UnitCode = resItem.UnitCode,
                        });
                    }
                }
                else
                {

                    model.OrderNr += "-" + resultModel.OrderNr;
                    model.OrderIdList.Add(item);
                    foreach (var resItem in resultModel.Items)
                    {
                        model.Items.Add(new ShippingItem()
                        {
                            Barcode = resItem.Barcode,
                            ItemCode = resItem.ItemCode,
                            ItemName = resItem.ItemName,
                            LeftAmount = resItem.LeftAmount,
                            LotNr = resItem.LotNr,
                            OrderAmount = resItem.OrderAmount,
                            Shipped = resItem.Shipped,
                            UnitCode = resItem.UnitCode,
                        });
                    }
                }
            }

            model.LabelInfo = new LabelInfoModel()
            {
                BoxCount = "1",
                Date = model.Date,
                Desi = "1",
                InvoiceCount = OrderIdList.Count().ToString(),
                LabelCount = "1",
                OrderNr = model.OrderNr,
                PaletNr = "1",
                OrderIdList = model.OrderIdList,
                Transporter = "1",
                Address1 = model.Address1,
                Address2 = model.Address2,
                City = model.City,
                ClDefintion = model.ClDefintion,
                Town = model.Town,

            };

            model.TotalAmount = model.Items.Sum(x => x.OrderAmount).ToString();
            List<SelectListItem> transporterSelectList = new List<SelectListItem>();
            transporterSelectList.Add(new SelectListItem { Text = "Yurt İçi Kargo", Value = "1" });
            transporterSelectList.Add(new SelectListItem { Text = "Aras Kargo", Value = "2" });
            transporterSelectList.Add(new SelectListItem { Text = "Kargolin", Value = "3" });
            transporterSelectList.Add(new SelectListItem { Text = "Elden Teslimat", Value = "4" });
            transporterSelectList.Add(new SelectListItem { Text = "Özel Servis", Value = "5" });
            ViewBag.TransporterSelectList = transporterSelectList;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Shipping(LabelInfoModel Model)
        {

            for (int i = 0; i < Convert.ToInt16(Model.LabelCount); i++)
            {
                LabelPrinter printer = new LabelPrinter(_converter);
                var pdf = printer.print(Model, i + 1);

                RawPrintHelper printHelper = new RawPrintHelper();
                printHelper.Print(pdf);
            }

            var result = await ApiHelper.PostAsync<LabelInfoModel>("http://localhost/api/Shipment/SetShippingClosed", Model);
            return RedirectToAction("Shipping", "ShippingList", new { OrderList = Model.OrderIdList });
        }


    }


}
