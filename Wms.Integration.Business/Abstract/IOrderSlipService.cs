using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.OrderSlip;

namespace Wms.Integration.Business.Abstract
{
    public interface IOrderSlipService: IBaseEntityService<OrderSlip>
    {
        Task<IDataResult<IList<OrderSlip>>> GetListAsync(OrderSlipListParameterDto dto);
    }
}
