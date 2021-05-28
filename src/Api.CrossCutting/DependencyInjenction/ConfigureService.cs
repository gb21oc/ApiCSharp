using Api.Domain.Interfaces.Services.User;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjenction
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection){
            serviceCollection.AddTransient<IUserService, UserService> ();
            serviceCollection.AddTransient<ILoginService, LoginService>();
        }
    }
}