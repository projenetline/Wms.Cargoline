using Microsoft.AspNetCore.Identity;

namespace Wms.Integration.WebUI.Data
{
    public class ApplicationRole:IdentityRole
    {
        public ApplicationRole(string roleName,string description):base(roleName)
        {
            Description = description;
        }

        public string Description { get; set; }
    }
}
