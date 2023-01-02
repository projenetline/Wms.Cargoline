using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wms.Integration.Entities.Dtos.Shipments
{
    public class ShipingListModel
    {
        public string OrderId { get; set; }
        public string LineNr { get; set; }
        public string ClCode { get; set; }
        public string ClDef { get; set; }
        public string OrderNr { get; set; }
        public string Date { get; set; }
        public string Docode { get; set; }
        public string ProjectType { get; set; }
        public string Serie { get; set; }
    }
}
