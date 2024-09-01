using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using theshoeshop.userservice.repository;
using theshoeshop.userservice.dataaccess;

namespace theshoeshop.userservice.infrasturcture
{
    public static class InfrasturctureExtension
    {
        public static IServiceCollection AddInfrasturcture(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDataAccessDependencies(configuration);
            services.AddRepository(configuration);

            return services;
        }
    }
}
