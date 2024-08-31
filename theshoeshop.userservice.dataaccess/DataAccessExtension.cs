using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using theshoeshop.userservice.dataaccess.Context;

namespace theshoeshop.userservice.dataaccess
{
    public static class DataAccessExtension
    {
        public static IServiceCollection AddDataAccessDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBContext>(db =>
            {
                db.UseSqlServer(configuration.GetConnectionString("database"));
            });

            return services;
        }
    }
}
