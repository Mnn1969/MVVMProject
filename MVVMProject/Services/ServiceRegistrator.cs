using Microsoft.Extensions.DependencyInjection;
using MVVMProject.Services.Interfaces;

namespace MVVMProject.Services
{
    static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<IDataService, DataService>()
            .AddTransient<IUserDialog, UserDialog>();
    }
}
