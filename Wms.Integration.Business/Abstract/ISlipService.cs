using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.Slip;

namespace Wms.Integration.Business.Abstract
{
    public interface ISlipService:IBaseEntityService<Slip>
    {
        Task<IDataResult<IList<Slip>>> GetListAsync(ListSlipDto dto);
        Task<IDataResult<PagedResult<Slip>>> GetPagedListAsync(ListSlipDto dto);
    }
}
