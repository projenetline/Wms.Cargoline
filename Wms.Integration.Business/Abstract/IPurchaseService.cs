using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Abstract
{
    public interface IPurchaseService
    {
        Task<IDataResult<WorkOrder>> CreateWorkOrderIAsync(WorkOrder workOrder);
    }
}
