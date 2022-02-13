using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SaveCars.ApplicationService.Interfaces.Service;
using SaveCars.ApplicationService.Services;
using SaveCars.Business.Interfaces.Context;
using SaveCars.Business.Interfaces.NotificationHandler;
using SaveCars.Business.Interfaces.Repository;
using SaveCars.Business.Interfaces.ValidationHandler;
using SaveCars.Business.NotificationSettings;
using SaveCars.Business.Validation.EntitiesValidation;
using SaveCars.Data.EntityFramework.Context;
using SaveCars.Data.EntityFramework.Wou;
using SaveCars.Data.Repository;
using SaveCars.Domain.Entities;
using System;

namespace SaveCars.IoC.DependencyInjectionHandler
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDependecyInjectionConfiguration(this IServiceCollection services, IConfiguration configuration = null)
        {
            services.AddDbContext<ApplicationDbContext>(config =>
            config.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
            x => x.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<ApplicationDbContext>();

            services.AddScoped<INotificationContext, NotificationContext>();

            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            

            services.AddScoped<IVehicleRepository, VehicleRepository>();

            services.AddScoped<IValidation<Vehicle>, VehicleValidation>();


            services.AddScoped<IVehicleService, VehicleService>();
        }
    }
}
