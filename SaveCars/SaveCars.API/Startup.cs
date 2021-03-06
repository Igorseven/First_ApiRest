using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using SaveCars.API.Filters;
using SaveCars.API.Filters.FiltersConfiguration;
using SaveCars.ApplicationService.AutoMapperSettings;
using SaveCars.IoC.DependencyInjectionHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaveCars.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            

            AutoMapperHandler.Initialize();
            services.AddDependecyInjectionConfiguration(Configuration);
            services.AddServiceFilters();
            
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SaveCars.API", Version = "v1" });
            });

            services.AddCors(config => config.AddPolicy(name: "default", config =>

                config.WithOrigins("http://localhost:4200;")
                .AllowAnyHeader()
                .AllowAnyMethod()
            ));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SaveCars.API v1"));
            }

            app.UseHttpsRedirection();
            app.UseCors("default");
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
