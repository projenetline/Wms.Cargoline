using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Abstract
{
    public interface ISysFactoryService:IBaseEntityService<SysFactory>
    {
        Task<IDataResult<SysFactory>> GetCodeAsync(string Code);
    }
}
