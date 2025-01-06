using Microsoft.Extensions.DependencyInjection;
using Trendora.Application.Common;
using Trendora.Application.Services;
using Trendora.Application.Services.Interface;

namespace Trendora.Application
{
    public static class ApplicationRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<ICatagoryService, CatagoryService>();
            services.AddScoped<IBrandService, BrandService>();
            return services;
        }
    }
}
