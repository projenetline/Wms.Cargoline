using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wms.Integration.Entities.Dtos.Shipments
{
    public class ShippingModel
    {

        public List<string> OrderIdList { get; set; } = new List<string>();
        public string OrderNr { get; set; }
        public string Date { get; set; }
        public string ClCode { get; set; }
        public string ClDefintion { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Barcode { get; set; }
        public string Amount { get; set; }
        public string TotalAmount { get; set; }
        public List<ShippingItem> Items { get; set; } = new List<ShippingItem>();
        public LabelInfoModel LabelInfo { get; set; } = new LabelInfoModel();
    }
    public class ShippingItem
    {

        public string Barcode { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string LotNr { get; set; }
        public string UnitCode { get; set; }
        public double OrderAmount { get; set; }
        public double Shipped { get; set; }
        public double LeftAmount { get; set; }
       
    }
    public class LabelInfoModel
    {
        public List<string> OrderIdList { get; set; } = new List<string>();
        public string OrderNr { get; set; }
        public string Date { get; set; }
        public string LabelCount { get; set; }
        public string BoxCount { get; set; }
        public string Desi { get; set; }
        public string InvoiceCount { get; set; }
        public string PaletNr { get; set; }
        public string Transporter { get; set; }
        public string ClDefintion { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
    }
}
