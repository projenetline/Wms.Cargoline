﻿using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysFactory:IBaseEntity
    {
        public SysFactory()
        {
            OrderSlips = new HashSet<OrderSlip>();
            PlanningSlips = new HashSet<PlanningSlip>();
            ProductionOrderLines = new HashSet<ProductionOrderLine>();
            ProductionOrders = new HashSet<ProductionOrder>();
            Slips = new HashSet<Slip>();
            SysWarehouses = new HashSet<SysWarehouse>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? DivisionId { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual SysDivision Division { get; set; }
        public virtual ICollection<OrderSlip> OrderSlips { get; set; }
        public virtual ICollection<PlanningSlip> PlanningSlips { get; set; }
        public virtual ICollection<ProductionOrderLine> ProductionOrderLines { get; set; }
        public virtual ICollection<ProductionOrder> ProductionOrders { get; set; }
        public virtual ICollection<Slip> Slips { get; set; }
        public virtual ICollection<SysWarehouse> SysWarehouses { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
