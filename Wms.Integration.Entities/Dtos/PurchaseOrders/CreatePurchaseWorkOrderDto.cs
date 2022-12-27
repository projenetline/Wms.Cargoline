using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Dtos.PurchaseOrders
{
    public class CreatePurchaseWorkOrderDto : IBaseDto
    {
        public string ArpCode { get; set; }
        public string SlipDate { get; set; }
        public string SlipNumber { get; set; }
        public string WarehouseCode { get; set; }
        public string FaturaNo { get; set; }
        public string DocumentNumber { get; set; }
        public string DocTrackingNumber { get; set; }
        public string Description { get; set; }
        public string SpeCode { get; set; }
        public string SpeCode2 { get; set; }
        public DateTime CompletedDate { get; set; }
        public IList<CreatePurchaseWorkOrderLineDto> lines { get; set; }




      //  public string ArpCode { get; set; }
      //  public string SlipNumber { get; set; }
      //  public string WarehouseCode { get; set; }
      //  public string ItemCode { get; set; }
      //  public string AddressCode { get; set; }
      //  public string DocumentNumber { get; set; }
      //  public string DepartmantCode { get; set; }
      //  public string DivisionCode { get; set; }
      //  public string FactoryCode { get; set; }
      //  public DateTime DocumentDate { get; set; }
      //  public int Priority { get; set; }
      //  public string PrintCount { get; set; }
      //  public int StateId { get; set; }
      //  public int Active { get; set; } 
      //  public DateTime CreatedDate { get; set; }
      //  public int CreatedBy { get; set; }
      //  public string TrackingNumber { get; set; }
      //  public DateTime ExpirationDate { get; set; }
      //  public DateTime LineDate { get; set; }
      //  public DateTime LineDay { get; set; }
    }
    public class CreatePurchaseWorkOrderLineDto
    {
        public int ItemId { get; set; }
        public string ItemCode { get; set; }
        public int UnitId { get; set; }
        public decimal Quantity { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string AddresCode { get; set; }
        public int AddressId { get; set; }
        public string Description { get; set; }
        public string AuthCode { get; set; }
       // public DateTime ProductionDate { get; set; }
    }
}
