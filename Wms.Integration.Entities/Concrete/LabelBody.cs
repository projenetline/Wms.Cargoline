using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public class LabelBody:IBaseEntity
    {
        public Guid Id { get; set; }    
        public int OrderId { get; set; }
        public Guid LabelHeaderId { get; set; }
        public LabelHeader LabelHeader { get; set; }
    }
}
