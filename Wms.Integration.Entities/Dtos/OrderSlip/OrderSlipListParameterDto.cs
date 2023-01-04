using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Dtos.OrderSlip
{
    public class OrderSlipListParameterDto:IBaseDto
    {
        public int StateId { get; set; }
        public string FirmNr { get; set; }
        public int StateId2 { get; set; } = 0;
    }
}
