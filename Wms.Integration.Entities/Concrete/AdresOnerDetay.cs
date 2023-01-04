using System;
using System.Collections.Generic;

namespace Wms.Integration.DataAccess
{
    public partial class AdresOnerDetay
    {
        public long? Rn { get; set; }
        public int ItemId { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Barcode { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? AddressId { get; set; }
        public string Address { get; set; }
        public string TrackingNumber { get; set; }
        public decimal? Stock { get; set; }
    }
}
