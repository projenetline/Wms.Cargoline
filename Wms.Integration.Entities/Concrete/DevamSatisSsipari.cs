using System;
using System.Collections.Generic;

namespace Wms.Integration.DataAccess
{
    public partial class DevamSatisSsipari
    {
        public int? Id { get; set; }
        public int SlipId { get; set; }
        public string DocumentNumber { get; set; }
        public string DocTrackingNumber { get; set; }
        public string StateName { get; set; }
        public string StateN { get; set; }
        public string Title { get; set; }
        public decimal? SlipTotal { get; set; }
        public decimal? RemainingTotal { get; set; }
        public decimal? CompletedRate { get; set; }
        public int? CreatedBy { get; set; }
    }
}
