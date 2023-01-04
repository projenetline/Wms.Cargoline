using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wms.Integration.Entities.Dtos.Shipments;

namespace Wms.Integration.Business.Abstract
{
    public interface IShipmentService
    {
        Task<bool> LabelCreate(LabelInfoModel labelInfoModel);

        Task<ShippingModel> GetOrder(string orderId);
        Task<bool> GetShipping(string sql);
    }
}
