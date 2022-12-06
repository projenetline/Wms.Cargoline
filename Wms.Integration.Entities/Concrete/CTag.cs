
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public class CTag : IEntity
    {
        public Guid Id { get ; set ; }
        public string DocumentNumber { get; set; }
        public DateTime Date { get; set; }
        public DateTime ShippingDate { get; set; }
        public string ArpCode { get; set; }
        public string Title { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Country { get; set; }
        public int TagAmount { get; set; }
        public int PackageAmount { get; set; }
        public double Desi { get; set; }
        public int SlipAmount { get; set; }
        public int Palette { get; set; }
        public int CarrierId { get; set; }
        public int PrinterId { get; set; }
        public bool PaletShippingChange { get; set; }
        public virtual Carrier Carrier { get; set; }
        public virtual SysPrinter Printer { get; set; }
      //  public int  { get; set; }
    }
}
