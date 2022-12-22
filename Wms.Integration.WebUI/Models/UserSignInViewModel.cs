using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace Wms.Integration.WebUI.Models
{
    public class UserSignInViewModel
    {
        //[Required(ErrorMessage="Lütfen kullanıcı adınızı giriniz!")]
     
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
