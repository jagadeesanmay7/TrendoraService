﻿using Microsoft.Extensions.DependencyInjection;
using Trendora.Domain.Contracts;
using Trendora.Domain.Interface;
using Trendora.Infrastructure.Repositories;

namespace Trendora.Infrastructure
{
    public static class InfrastructureRegistration
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ICatagoryRepository, CatagoryRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            return services;
        }
    }
}
