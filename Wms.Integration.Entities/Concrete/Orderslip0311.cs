using System;
using System.Collections.Generic;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class Orderslip0311: IBaseEntity
    {
        public int Id { get; set; }
        public short SlipType { get; set; }
        public string SlipNumber { get; set; }
        public DateTime SlipDate { get; set; }
        public int? ArpId { get; set; }
        public int? DeliveryArpId { get; set; }
        public int? ShipmentAddressId { get; set; }
        public int? WarehouseId { get; set; }
        public int? Warehouse2Id { get; set; }
        public string DocumentNumber { get; set; }
        public string CustomCode { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public int? DepartmentId { get; set; }
        public int? DivisionId { get; set; }
        public int? FactoryId { get; set; }
        public int? Department2Id { get; set; }
        public int? Division2Id { get; set; }
        public int? Factory2Id { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryType { get; set; }
        public int? CarrierId { get; set; }
        public string TradingGroupCode { get; set; }
        public short Priority { get; set; }
        public int? SalesPersonId { get; set; }
        public int? VehicleId { get; set; }
        public string DocTrackingNumber { get; set; }
        public int PrintCount { get; set; }
        public string CustomerOrderNumber { get; set; }
        public short ShipmentStatus { get; set; }
        public int StateId { get; set; }
        public int? ProjectId { get; set; }
        public int? ProductionOrderId { get; set; }
        public int? ProdOrderLineId { get; set; }
        public string AuthCode { get; set; }
        public short Active { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
