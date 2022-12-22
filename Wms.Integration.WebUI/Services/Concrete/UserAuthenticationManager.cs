using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Wms.Integration.DataAccess.Concrete.Contexts;
using Wms.Integration.WebUI.Data;
using Wms.Integration.WebUI.Models;
using Wms.Integration.WebUI.Services.Abstract;

namespace Wms.Integration.WebUI.Services.Concrete
{
    public class UserAuthenticationManager:IUserAuthenticationService
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<ApplicationRole> roleManager;

        public UserAuthenticationManager(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        public async Task<ResultViewModel> LoginAsync(UserSignInViewModel model)
        {
            ResultViewModel resultViewModel=new ResultViewModel();
            ApplicationUser user =await userManager.FindByNameAsync(model.UserName);
            if (user == null)
            {
                resultViewModel.Result = false;
                resultViewModel.Message = "Kullanıcı bulunamadı!";
                resultViewModel.Data = null;
                return resultViewModel;
            }
            if(!await userManager.CheckPasswordAsync(user, model.Password))
            {
                resultViewModel.Result = false;
                resultViewModel.Message = "Lütfen şifrenizi tekrar giriniz!";
                resultViewModel.Data = null;
                return resultViewModel;
            }
            var signInResult=await signInManager.PasswordSignInAsync(user,model.Password,true,true);
            if(signInResult.Succeeded)
            {
                var userRoles=await userManager.GetRolesAsync(user);
                var authclaims=new List<Claim>{ 
                    new Claim(ClaimTypes.Name,model.UserName),
                };
                foreach (var userRole in userRoles)
                {
                    authclaims.Add(new Claim(ClaimTypes.Role, userRole));
                }
            }
            else if(signInResult.IsLockedOut)
            {
                resultViewModel.Result=false;
                resultViewModel.Message = "Bu kullanıcı kilitlendi!";
                resultViewModel.Data=null;
                return resultViewModel;
            }
            else
            {
                resultViewModel.Result=false;
                resultViewModel.Message = "Giriş yapılamadı!";
                resultViewModel.Data = null;
                return resultViewModel;
            }
            return resultViewModel;
        }
        public async Task LogoutAsync()
        {
            await signInManager.SignOutAsync();
        }
        public async Task<ResultViewModel> RegistrationAsync(UserRegistrationViewModel model)
        {
            ResultViewModel resultViewModel= new ResultViewModel();
            ApplicationUser userExits=await userManager.FindByNameAsync(model.UserName);
            if(userExits!=null)
            {
                resultViewModel.Result = false;
                resultViewModel.Message = "Bu kullanıcı bulunmaktadır!";
                resultViewModel.Data = userExits;
                return resultViewModel;
            }
            userExits = new ApplicationUser
            {
                SecurityStamp = Guid.NewGuid().ToString(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.UserName,
                Password = model.Password,
                EmailConfirmed = true,
            };
           IdentityResult result= await userManager.CreateAsync(userExits);
           if(result.Succeeded)
           {
                if(!await roleManager.RoleExistsAsync(model.Role))
                {
                    await roleManager.CreateAsync(new ApplicationRole(model.Role,""));
                }
                if(await roleManager.RoleExistsAsync(model.Role))
                {
                    await userManager.AddToRoleAsync(userExits, model.Role);
                }

               resultViewModel.Result = true;
               resultViewModel.Message = "Kullanıcı başarılı bir şekil de oluşturuldu.";
               resultViewModel.Data = userExits;
           }
           else
           {
               resultViewModel.Result = false;
               resultViewModel.Message = "Bu kullanıcı bulunmaktadır!";
               resultViewModel.Data = userExits;
           }
           return resultViewModel;
        }
    }
}
