using Wms.Integration.WebUI.Models;

namespace Wms.Integration.WebUI.Services.Abstract
{
    public interface IUserAuthenticationService
    {
        Task<ResultViewModel> LoginAsync(UserSignInViewModel model);
        Task<ResultViewModel> RegistrationAsync(UserRegistrationViewModel model);
        Task LogoutAsync();
    }
}
