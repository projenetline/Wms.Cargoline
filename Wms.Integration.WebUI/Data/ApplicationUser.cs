using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wms.Integration.DataAccess.Concrete.Contexts
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Display(Name = "İsim")]
        [Required(ErrorMessage = "Lütfen isminizi giriniz!")]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Display(Name = "Soy isim")]
        [Required(ErrorMessage = "Lütfen soy isminizi giriniz!")]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [PersonalData]
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage ="Lütfen kullanıcı adını giriniz!")]
        [Column(TypeName ="nvarchar(100)")]
        public string UserName { get; set; }

        [PersonalData]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz!")]
        [Column(TypeName = "nvarchar(100)")]
        public string Password { get; set; }
    }
}
