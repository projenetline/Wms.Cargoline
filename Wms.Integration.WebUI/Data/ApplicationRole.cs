using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Wms.Integration.WebUI.Data
{
    public class ApplicationRole:IdentityRole<string>
    {
        [StringLength(200)]
        public string Description { get; set; }
    }
}
