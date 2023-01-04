using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.Shipments;
using Wms.Integration.Entities.Dtos.OrderSlip;
using System.Reflection.Emit;

namespace Wms.Integration.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowAllHeaders")]
    [ApiController]
    public class ShipmentController : ControllerBase
    {
        private readonly IOrderSlipService _orderSlipService;
        private readonly IOrderSlipLineService _orderSlipLineService;
        private readonly IShipmentService _shipmentService;

        public ShipmentController(IOrderSlipService orderSlipService, IOrderSlipLineService orderSlipLineService, IShipmentService shipmentService)
        {
            _orderSlipService = orderSlipService;
            _orderSlipLineService = orderSlipLineService;
            _shipmentService = shipmentService;
        }

        [HttpGet("GetShipmentList")]
        public async Task<List<ShipingListModel>> GetShipmentList(string FirmNr)
        {
            IDataResult<IList<OrderSlip>> dataResult= await _orderSlipService.GetListAsync(new OrderSlipListParameterDto{StateId=23,StateId2=25,FirmNr=FirmNr });
            if (dataResult.Success)
            {
                return dataResult.Data.Select((s, Index) => new ShipingListModel
                {
                    OrderId = s.Id.ToString(),
                    ClCode = s.Arp.Code,
                    ClDef = s.Arp.Title,
                    Date = s.SlipDate.ToString(),
                    LineNr = Index.ToString(),
                    OrderNr = s.SlipNumber,
                    ProjectType = s.Project.Code,
                    Serie = s.DocTrackingNumber
                }).ToList(); //new List<ShipingListModel>();
            }
            else
            {
                return new List<ShipingListModel>();
            }
            #region İsmail

            //List<ShipingListModel> shipingListModels = new List<ShipingListModel>();
            //shipingListModels.Add(new ShipingListModel()
            //{
            //    OrderId = "1",
            //    ClCode = "120.05.0002100",
            //    ClDef = "AYSE LONGA",
            //    Date = "2022-12-28",
            //    Docode = "",
            //    LineNr = "1",
            //    OrderNr = "00290987",
            //    ProjectType = "BIOBONUS",
            //    Serie = "1"
            //});
            //shipingListModels.Add(new ShipingListModel()
            //{
            //    OrderId = "2",
            //    ClCode = "120.01.09.089",
            //    ClDef = "ERGİN ECZANESİ-ECZ.M.YAŞAR ERGİN",
            //    Date = "2022-12-27",
            //    Docode = "",
            //    LineNr = "2",
            //    OrderNr = "00290991",
            //    ProjectType = "RPT",
            //    Serie = "3"
            //});
            //shipingListModels.Add(new ShipingListModel()
            //{
            //    OrderId = "3",
            //    ClCode = "120.01.09.089",
            //    ClDef = "ERGİN ECZANESİ-ECZ.M.YAŞAR ERGİN",
            //    Date = "2022-12-28",
            //    Docode = "",
            //    LineNr = "3",
            //    OrderNr = "00290900",
            //    ProjectType = "RPT",
            //    Serie = "3"
            //});
            //shipingListModels.Add(new ShipingListModel()
            //{
            //    OrderId = "4",
            //    ClCode = "120.05.0048419",
            //    ClDef = "HANDE ERTÜRK",
            //    Date = "2022-12-28",
            //    Docode = "",
            //    LineNr = "4",
            //    OrderNr = "00290988",
            //    ProjectType = "BIOBONUS",
            //    Serie = "2"
            //});


            //return shipingListModels;
            #endregion
        }


        [HttpGet("GetShippingDetail")]
        public async Task<ShippingModel> GetShippingDetail(string OrderId)
        {
            string sql="";
            sql = "update OrderSlip set StateId=27 where Id in (" + OrderId.Replace('-', ',') + ")";
            await _shipmentService.GetShipping(sql);
            sql = "update OrderSlipLine set StateId=27 where SlipId in (" + OrderId.Replace('-', ',') + ")";
            await _shipmentService.GetShipping(sql);
            return await _shipmentService.GetOrder(OrderId.Replace('-', ','));
           

            //IDataResult<OrderSlip> dataResult= await _orderSlipService.GetAsync(int.Parse(OrderId));
            //if (dataResult.Success)
            //{
            //    return new ShippingModel
            //    {
            //        OrderNr = dataResult.Data.SlipNumber,
            //        Date = dataResult.Data.SlipDate.ToString("dd.MM.yyyy"),
            //        Address1 = dataResult.Data.ShipmentAddress.Address1,
            //        Address2 = dataResult.Data.ShipmentAddress.Address2,
            //        City = dataResult.Data.ShipmentAddress.City,
            //        Town = dataResult.Data.ShipmentAddress.Town,
            //        Barcode = "", // sabit
            //        Amount = "1", // sabit
            //        ClCode = dataResult.Data.Arp.Code,
            //        ClDefintion = dataResult.Data.Arp.Title,
            //        Items = dataResult.Data.OrderSlipLines.Select(s => new ShippingItem
            //        {
            //            ItemName = s.Item.Name,
            //            Barcode = s.Item.UnitBarcodes.FirstOrDefault(t => t.ItemId == s.ItemId) == null ? "" : s.Item.UnitBarcodes.FirstOrDefault(t => t.ItemId == s.ItemId).Barcode,
            //            ItemCode = s.Item.Code,
            //            LeftAmount = Convert.ToDouble(s.Quantity),
            //            OrderAmount = Convert.ToDouble(s.Quantity),
            //            Shipped = 0,
            //            UnitCode = "Adet",
            //            LotNr = "",
            //        }).ToList(),
            //        LabelInfo = new LabelInfoModel()
            //    };
            //}
            //else
            //{
            //    return new ShippingModel();
            //}
            #region İsmail
           //ShippingModel shipingListModels=new ShippingModel();
           //shipingListModels.OrderNr = "00290988";
           //shipingListModels.Date = DateTime.Today.ToString("dd.MM.yyyy");
           //shipingListModels.Address1 = " Ataşehir";
           //shipingListModels.Address2 = " Ataşehir ";
           //shipingListModels.City = "İstanbul";
           //shipingListModels.Town = "Ataşehir";
           //shipingListModels.Barcode = ""; // sabit
           //shipingListModels.Amount = "1"; // sabit
           //shipingListModels.ClCode = "120.01.09.089";
           //shipingListModels.ClDefintion = "ERGİN ECZANESİ-ECZ.M.YAŞAR ERGİN";
           //shipingListModels.Items.Add(new ShippingItem()
           //{
           //
           //    Barcode = "3760201231746",
           //    ItemCode = "31301746",
           //    ItemName = "PURIFYING CLEANSING GEL T5 ML",
           //    LeftAmount = 20,
           //    OrderAmount = 20,
           //    Shipped = 0,
           //    UnitCode = "Adet",
           //    LotNr = "25354",
           //
           //
           //
           //});
           //shipingListModels.Items.Add(new ShippingItem()
           //{
           //
           //    Barcode = "3760201231715",
           //    ItemCode = "31109016",
           //    ItemName = "PURE ACTIVE ENOXOLONE 1 ML",
           //    LeftAmount = 10,
           //    OrderAmount = 10,
           //    Shipped = 0,
           //    UnitCode = "Adet",
           //    LotNr = "12354",
           //
           //
           //
           //});
           //shipingListModels.Items.Add(new ShippingItem()
           //{
           //
           //    Barcode = "3701129805343",
           //    ItemCode = "1001103466",
           //    ItemName = "ATODERM CREAM ULTRA 500 ML",
           //    LeftAmount = 10,
           //    OrderAmount = 10,
           //    Shipped = 0,
           //    UnitCode = "Adet",
           //    LotNr = "L125852",
           //
           //
           //});
           //shipingListModels.Items.Add(new ShippingItem()
           //{
           //
           //    Barcode = "8699956510446",
           //    ItemCode = "1003993562",
           //    ItemName = "SENSIBIO H2O 500ML İKİZ KOFRE",
           //    LeftAmount = 12,
           //    OrderAmount = 12,
           //    Shipped = 0,
           //    UnitCode = "Adet",
           //    LotNr = "S123658"
           //
           //
           //});
           //shipingListModels.Items.Add(new ShippingItem()
           //{
           //
           //    Barcode = "8699956510446",
           //    ItemCode = "1003993562",
           //    ItemName = "SENSIBIO H2O 500ML İKİZ KOFRE",
           //    LeftAmount = 12,
           //    OrderAmount = 12,
           //    Shipped = 0,
           //    UnitCode = "Adet",
           //    LotNr = "S124874"
           //
           //
           //});
           //shipingListModels.TotalAmount = shipingListModels.Items.Sum(x => x.OrderAmount).ToString();
           //return shipingListModels;
           #endregion

        }


        [HttpPost("SetShippingClosed")]
        public async Task<bool> SetShippingClosed(LabelInfoModel label)
        {
            string sql="";
            string id="";
            bool first=true;
            foreach (string item in label.OrderIdList)
            {
                if(first) 
                     id= id+ item;
                else
                    id= id+","+ item;
                first = false;
            }
            if (sql != "")
            {
                sql = "update OrderSlip set StateId=27 where Id in (" + id + ")";
                await _shipmentService.GetShipping(sql);
                sql = "update OrderSlipLine set StateId=27 where SlipId in (" + id + ")";
                await _shipmentService.GetShipping(sql);
            }
            bool result=await _shipmentService.LabelCreate(label);

            return true;
        }

    }
}
