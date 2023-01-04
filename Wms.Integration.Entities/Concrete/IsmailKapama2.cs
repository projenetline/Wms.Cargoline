using System;
using System.Collections.Generic;

namespace Wms.Integration.DataAccess
{
    public partial class IsmailKapama2
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Code { get; set; }
        public decimal Quantity { get; set; }
        public decimal? Quantity2 { get; set; }
        public int Shipped { get; set; }
        public string UnitCode { get; set; }
        public string TrackingNumber { get; set; }
    }
}
