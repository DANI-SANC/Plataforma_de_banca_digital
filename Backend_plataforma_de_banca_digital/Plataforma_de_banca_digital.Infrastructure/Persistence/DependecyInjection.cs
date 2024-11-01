using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plataforma_de_banca_digital.Infrastructure.Persistence
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddPersistence( this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbContextSQL>(opt =>
            {
            opt.LogTo(Console.WriteLine, new[]
            {
                DbLoggerCategory.Database.Command.Name
            }, LogLevel.Information).EnableSensitiveDataLogging();

                opt.UseSqlServer(configuration.GetConnectionString("SQL"));
            });

            return services;
        }
    }
}
