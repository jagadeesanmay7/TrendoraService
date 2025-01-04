using Microsoft.Extensions.DependencyInjection;
using Trendora.Domain.Interface;
using Trendora.Infrastructure.Repositories;

namespace Trendora.Infrastructure
{
    public static class InfrastructureRegistration
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            return services;
        }
    }
}
