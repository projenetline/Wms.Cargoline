using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Entities.Dtos.PurchaseOrders
{
    public class CreateHareketDto:IBaseDto
    {
        public int SlipType { get; set; }
        public DateTime LineDate { get; set; }
        public int OrderId { get; set; }
        public WorkOrder  workOrder { get; set; }
        public IList<WorkOrderLine> workOrderLines { get; set; }
        public IList<TransactionDetail> transactionDetail { get; set; }
    }
}
