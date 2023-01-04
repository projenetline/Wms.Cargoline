using System;
using System.Collections.Generic;

namespace Wms.Integration.DataAccess
{
    public partial class EmirFisiAdetDetay
    {
        public int SlipId { get; set; }
        public int? OrderSlipLineId { get; set; }
        public decimal? Quantity { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
