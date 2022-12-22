using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Dtos.PurchaseOrders
{
    public class CreatePurchaseWorkOrderDto:IBaseDto
    {
        public string ArpCode { get; set; }
        public string SlipNumber { get; set; }
        public string WarehouseCode { get; set; }
        public string ItemCode { get; set; }
        public string AddressCode { get; set; }
        public string DocumentNumber { get; set; }
        public string DepartmantCode { get; set; }
        public string DivisionCode { get; set; }
        public string FactoryCode { get; set; }
        public DateTime DocumentDate { get; set; }
        public int Priority { get; set; }
        public string PrintCount { get; set; }
        public int StateId { get; set; }
        public int Active { get; set; } 
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime LineDate { get; set; }
        public DateTime LineDay { get; set; }
    }
}
