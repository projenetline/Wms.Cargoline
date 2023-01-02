using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.DecompositionShelfs;
using Wms.Integration.Entities.Dtos.Shipments;

namespace Wms.Integration.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowAllHeaders")]
    [ApiController]
    public class ShipmentController : ControllerBase
    {
        [HttpGet("GetShipmentList")]
        public async Task<List<ShipingListModel>> GetShipmentList(string FirmNr)
        {
            List<ShipingListModel> shipingListModels = new List<ShipingListModel>();
            shipingListModels.Add(new ShipingListModel()
            {
                OrderId = "1",
                ClCode = "120.05.0002100",
                ClDef = "AYSE LONGA",
                Date = "2022-12-28",
                Docode = "",
                LineNr = "1",
                OrderNr = "00290987",
                ProjectType = "BIOBONUS",
                Serie = "1"
            });
            shipingListModels.Add(new ShipingListModel()
            {
                OrderId = "2",
                ClCode = "120.01.09.089",
                ClDef = "ERGİN ECZANESİ-ECZ.M.YAŞAR ERGİN",
                Date = "2022-12-27",
                Docode = "",
                LineNr = "2",
                OrderNr = "00290991",
                ProjectType = "RPT",
                Serie = "3"
            });
            shipingListModels.Add(new ShipingListModel()
            {
                OrderId = "3",
                ClCode = "120.01.09.089",
                ClDef = "ERGİN ECZANESİ-ECZ.M.YAŞAR ERGİN",
                Date = "2022-12-28",
                Docode = "",
                LineNr = "3",
                OrderNr = "00290900",
                ProjectType = "RPT",
                Serie = "3"
            });
            shipingListModels.Add(new ShipingListModel()
            {
                OrderId = "4",
                ClCode = "120.05.0048419",
                ClDef = "HANDE ERTÜRK",
                Date = "2022-12-28",
                Docode = "",
                LineNr = "4",
                OrderNr = "00290988",
                ProjectType = "BIOBONUS",
                Serie = "2"
            });


            return shipingListModels;
        }



        [HttpGet("GetShippingDetail")]
        public async Task<ShippingModel> GetShippingDetail(string OrderId)
        {
            ShippingModel shipingListModels = new ShippingModel();

            shipingListModels.OrderNr = "00290988";
            shipingListModels.Date = DateTime.Today.ToString("dd.MM.yyyy");
            shipingListModels.Address1 = " Ataşehir";
            shipingListModels.Address2 = " Ataşehir ";
            shipingListModels.City = "İstanbul";
            shipingListModels.Town = "Ataşehir";
            shipingListModels.Barcode = ""; // sabit
            shipingListModels.Amount = "1"; // sabit
            shipingListModels.ClCode = "120.01.09.089";
            shipingListModels.ClDefintion = "ERGİN ECZANESİ-ECZ.M.YAŞAR ERGİN";
            shipingListModels.Items.Add(new ShippingItem()
            {

                Barcode = "3760201231746",
                ItemCode = "31301746",
                ItemName = "PURIFYING CLEANSING GEL T5 ML",
                LeftAmount = 20,
                OrderAmount = 20,
                Shipped = 0,
                UnitCode = "Adet",
                LotNr = "25354",



            });
            shipingListModels.Items.Add(new ShippingItem()
            {

                Barcode = "3760201231715",
                ItemCode = "31109016",
                ItemName = "PURE ACTIVE ENOXOLONE 1 ML",
                LeftAmount = 10,
                OrderAmount = 10,
                Shipped = 0,
                UnitCode = "Adet",
                LotNr = "12354",



            });
            shipingListModels.Items.Add(new ShippingItem()
            {

                Barcode = "3701129805343",
                ItemCode = "1001103466",
                ItemName = "ATODERM CREAM ULTRA 500 ML",
                LeftAmount = 10,
                OrderAmount = 10,
                Shipped = 0,
                UnitCode = "Adet",
                LotNr = "L125852",


            });
            shipingListModels.Items.Add(new ShippingItem()
            {

                Barcode = "8699956510446",
                ItemCode = "1003993562",
                ItemName = "SENSIBIO H2O 500ML İKİZ KOFRE",
                LeftAmount = 12,
                OrderAmount = 12,
                Shipped = 0,
                UnitCode = "Adet",
                LotNr = "S123658"


            });
            shipingListModels.Items.Add(new ShippingItem()
            {

                Barcode = "8699956510446",
                ItemCode = "1003993562",
                ItemName = "SENSIBIO H2O 500ML İKİZ KOFRE",
                LeftAmount = 12,
                OrderAmount = 12,
                Shipped = 0,
                UnitCode = "Adet",
                LotNr = "S124874"


            });
            shipingListModels.TotalAmount = shipingListModels.Items.Sum(x => x.OrderAmount).ToString();
            return shipingListModels;
        }


        [HttpPost("SetShippingClosed")]
        public async Task<bool> SetShippingClosed(LabelInfoModel label)
        {



            return true;
        }

    }
}
