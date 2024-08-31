using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace theshoeshop.userservice.repository
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepository(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            return services;
        }
    }
}
