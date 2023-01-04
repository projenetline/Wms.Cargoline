using System;
using System.Collections.Generic;

namespace Wms.Integration.DataAccess
{
    public partial class DevamSatisSsiparisSatir
    {
        public decimal? CompletedRate { get; set; }
        public decimal LineTotal { get; set; }
        public decimal ShippedTotal { get; set; }
        public decimal? RemainingTotal { get; set; }
        public int? ItemId { get; set; }
        public string Barcode { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? SlipId { get; set; }
        public string DocumentNumber { get; set; }
        public int? Id { get; set; }
        public string SlipNumber { get; set; }
    }
}
