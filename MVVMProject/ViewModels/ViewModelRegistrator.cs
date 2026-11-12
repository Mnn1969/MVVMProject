using Microsoft.Extensions.DependencyInjection;

namespace MVVMProject.ViewModels
{
    internal static class ViewModelRegistrator
    {
        public static IServiceCollection AddViews(this IServiceCollection services) => services
            .AddSingleton<MainWindowViewModel>();
    }
}
