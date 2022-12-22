using Wms.Integration.WebUI.Services.Abstract;
using Wms.Integration.WebUI.Services.Concrete;

namespace Wms.Integration.WebUI.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection UseService(this IServiceCollection services)
        {
            services.AddScoped<IUserAuthenticationService, UserAuthenticationManager>();
            return services; 
        }
    }
}
