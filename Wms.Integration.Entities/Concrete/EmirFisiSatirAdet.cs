using System;
using System.Collections.Generic;

namespace Wms.Integration.DataAccess
{
    public partial class EmirFisiSatirAdet
    {
        public int SlipId { get; set; }
        public int? OrderSlipLineId { get; set; }
        public decimal? Quantity { get; set; }
    }
}
