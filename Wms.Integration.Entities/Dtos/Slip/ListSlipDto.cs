using Wms.Integration.Core.Entities.Dtos;

namespace Wms.Integration.Entities.Dtos.Slip
{
    public class ListSlipDto : PageListParameterDto
    {
        public int StateId { get; set; }
    }
}
