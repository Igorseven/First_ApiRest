using Microsoft.Extensions.DependencyInjection;

namespace SaveCars.API.Filters.FiltersConfiguration
{
    public static class ServiceFilterConfiguration
    {
        public static void AddServiceFilters(this IServiceCollection services)
        {
            services.AddMvc(config =>
            {
                config.Filters.AddService<ErrorAttributeFilter>();
                //config.Filters.AddService<UnitOfWorkFilter>();
            });

            services.AddScoped<ErrorAttributeFilter>();
            //services.AddScoped<UnitOfWorkFilter>();

        }
    }
}
