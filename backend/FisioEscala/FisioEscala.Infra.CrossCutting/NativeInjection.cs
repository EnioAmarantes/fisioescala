using FisioEscala.Application.Interfaces.Auth;
using FisioEscala.Domain.Interfaces.Auth;
using FisioEscala.Domain.Services;
using FisioEscala.Infra.Contexts;
using FisioEscala.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FisioEscala.Infra
{
    public static class NativeInjection
    {
        public static IServiceCollection FisioEscalaConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigServices();
            services.ConfigRepositories();
            services.ConfigDataBase(configuration);

            return services;
        }

        private static IServiceCollection ConfigServices(this IServiceCollection services)
        {
            services.AddScoped<ILoginService, LoginService>();
            return services;
        }

        private static IServiceCollection ConfigRepositories(this IServiceCollection services)
        {
            services.AddTransient<ILoginRepository, LoginRepository>();
            return services;
        }

        private static IServiceCollection ConfigDataBase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AuthDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("FisioEscala")));

            return services;
        }
    }
}
