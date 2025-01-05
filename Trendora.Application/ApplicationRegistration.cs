using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return services;
        }
    }
}
