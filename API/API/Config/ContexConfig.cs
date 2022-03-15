using Infraestructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Config
{
    public static class ContexConfig
    {
        public static void Setup(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ContextApi>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
