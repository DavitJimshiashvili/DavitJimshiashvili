using Microsoft.Extensions.DependencyInjection;
using RealEstateW.Services.Abstractions;
using RealEstateW.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateWeb.Infrastructure.Exstensions
{
    public static class ServiceExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IRealEstateService, RealEstateService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJWTService, JWTService>();



            services.AddRepositories();


        }
    }
}
