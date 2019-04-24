using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using LMS.API.Configuration;
using LMS.API.Controllers;
using LMS.DALL;
using LMS.MANAGER;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;



namespace LMS.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureSqlContext(Configuration);
            services.ConfigureRepositoryWrapper();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.ConfigureCors();
            //services.AddTransient<IUserService, UserService>();
            //services.AddTransient<IUserManager, UserManager>();
            //services.AddTransient<IUserDal, UserDal>();
            //Now register our services with Autofac container
            // var builder = new ContainerBuilder();
            // builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            //  builder.RegisterAssemblyTypes(
            //   typeof(ValuesController).Assembly)
            //  .AsImplementedInterfaces()
            //  .InstancePerLifetimeScope();

            // When you do service population, it will include your controller
            // types automatically.
            // builder.Populate(services);

            // If you want to set up a controller for, say, property injection
            // you can override the controller registration after populating services.
            // builder.RegisterType<ValuesController>().PropertiesAutowired();

            // var container = builder.Build();
            //Create the IServiceProvider based on the container.
            // container.Resolve<IUserService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //app.UseExceptionHandler("/Error"); if you have custom error
                app.UseHsts(); // HSTS Middleware (UseHsts) to send HTTP Strict Transport Security Protocol (HSTS) headers to clients.
            }
            app.UseHttpsRedirection(); // HTTPS Redirection Middleware (UseHttpsRedirection) to redirect HTTP requests to HTTPS.
            app.UseCors("LMSCors");
            app.UseStaticFiles(); // For the wwwroot folder
            app.UseMvc();
        }
    }
}
