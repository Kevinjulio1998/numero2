using System;
using Microsoft.Extensions.DependencyInjection;
using Services.Injection;

namespace Registro.Config
{
    public static class InjectionConfig
    {
        public static void InjectionSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            DependencyInjection.RegisterServices(services);

        }
    }
}
