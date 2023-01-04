using System;
using System.Collections.Generic;

namespace Wms.Integration.DataAccess
{
    public partial class SysErpFirm0201
    {
        public int Id { get; set; }
        public int ErpId { get; set; }
        public int? ParentFirmId { get; set; }
        public int ErpFirmNumber { get; set; }
        public string ErpFirmName { get; set; }
        public int? ErpBranchNumber { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
