using LMS.DALL.Data;
using LMS.DALL.Repository;
using LMS.MANAGER;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.API.Configuration
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionString:LMSDB"];

            services.AddDbContext<LMSContext>(options =>
               options.UseSqlServer(connectionString));
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            services.AddScoped<IUserManager, UserManager>();
        }

        //Cross-Origin Resource Sharing
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(x => x.AddPolicy("LMSCors", builder =>
            {
                builder.AllowAnyMethod() // Allow any header from HTTP
                        .AllowAnyHeader() //Allow PUT/POST/GET/DELETE
                        .AllowAnyOrigin(); //allow request to any domain
            }));
        }
    }
}
