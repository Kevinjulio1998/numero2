using Microsoft.Extensions.DependencyInjection;
using Services.Services;

namespace Services.Injection
{
    public class DependencyInjection
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IClass1, Class1>();
        }
    }
}