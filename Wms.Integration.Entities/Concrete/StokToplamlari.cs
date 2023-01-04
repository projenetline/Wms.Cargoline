using System;
using System.Collections.Generic;

namespace Wms.Integration.DataAccess
{
    public partial class StokToplamlari
    {
        public string Barcode { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal? ActualStock { get; set; }
        public string Address { get; set; }
        public string TrackingNumber { get; set; }
    }
}
