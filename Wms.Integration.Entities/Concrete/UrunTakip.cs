using System;
using System.Collections.Generic;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class UrunTakip: IBaseEntity
    {
        public long? Id { get; set; }
        public long? TakipId { get; set; }
        public int? StkId { get; set; }
        public string TakipNo { get; set; }
        public int DepoId { get; set; }
        public string Adres { get; set; }
        public string PaletBarkod { get; set; }
        public decimal? Miktar { get; set; }
        public string DepoKodu { get; set; }
        public int? BirimId { get; set; }
        public int? Birim { get; set; }
        public string StkKodu { get; set; }
        public DateTime SonkullanmaTarihi { get; set; }
    }
}
