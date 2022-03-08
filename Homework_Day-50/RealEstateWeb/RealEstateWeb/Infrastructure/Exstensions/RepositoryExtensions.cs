using Microsoft.Extensions.DependencyInjection;
using RealEstateW.Data;
using RealEstateW.DataEF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateWeb.Infrastructure.Exstensions
{
    public static  class RepositoryExtensions
    {

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRealEstateRepository, RealEstateRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        }
    }
}
