using System;
using Microsoft.Extensions.DependencyInjection;

namespace API.Config
{
    public static class Mapper
    {
        public static void AutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
