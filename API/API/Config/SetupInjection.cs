using System;
using Infraestructure.Injection;
using Microsoft.Extensions.DependencyInjection;

namespace API.Config
{
    public static class SetupInjection
    {
        public static void InjectionSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
             DependencyInjection.RegisterServices(services);
        }
    }

}
