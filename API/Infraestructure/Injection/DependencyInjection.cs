using System;
using Application.Service;
using Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure.Injection
{
    public static class DependencyInjection
    {

        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IServiceLogin, ServiceLogin>();
         
        }
    }
}
