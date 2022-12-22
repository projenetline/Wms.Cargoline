using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.PurchaseOrders;

namespace Wms.Integration.Business.Extensions
{
    public static class MappingExtensions
    {
        public static WorkOrder CreateWorkOrder(CreatePurchaseWorkOrderDto dto)
        {
            return new WorkOrder {

            };
        }
    }
}
