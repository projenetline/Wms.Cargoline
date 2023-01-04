using System;
using System.Collections.Generic;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class BaslamayanSatisSsipari: IBaseEntity
    {
        public int Id { get; set; }
        public short SlipType { get; set; }
        public string SlipNumber { get; set; }
        public string DocumentNumber { get; set; }
        public string DocTrackingNumber { get; set; }
        public decimal? SlipTotal { get; set; }
        public decimal? RemainingTotal { get; set; }
        public decimal? CompletedRate { get; set; }
        public int? ArpId { get; set; }
        public string ArpCode { get; set; }
        public string ArpTitle { get; set; }
        public int? ErpFirmId { get; set; }
    }
}
