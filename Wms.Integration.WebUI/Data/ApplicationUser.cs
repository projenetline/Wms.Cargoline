using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wms.Integration.DataAccess.Concrete.Contexts
{
    public class ApplicationUser : IdentityUser<string>
    {
   
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }   
     
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

   
    }
 
}
