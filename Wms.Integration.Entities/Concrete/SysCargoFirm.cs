using System;
using System.Collections.Generic;

namespace Wms.Integration.DataAccess
{
    public partial class SysCargoFirm
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public int CargoFirm { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public short Active { get; set; }
    }
}
