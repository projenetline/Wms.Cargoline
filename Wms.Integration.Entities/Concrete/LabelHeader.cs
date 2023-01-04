using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public class LabelHeader : IBaseEntity
    {
        public Guid Id { get; set; }
        public string OrderNr { get; set; }
        public string Date { get; set; }
        public string LabelCount { get; set; }
        public string BoxCount { get; set; }
        public string Desi { get; set; }
        public string InvoiceCount { get; set; }
        public string PaletNr { get; set; }
        public string Transporter { get; set; }
        public string ClDefintion { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public ICollection<LabelBody> labelBodies { get; set; }
    }
}
