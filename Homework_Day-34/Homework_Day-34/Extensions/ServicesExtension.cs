using Microsoft.Extensions.DependencyInjection;
using MoviesService.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_Day_34.Extensions
{
    public static class ServicesExtension
    {

        public static void AddServices(this IServiceCollection services)
        {
            services.AddSingleton<ISingletonMovieService, MoviesService.MovieService>();
        }
    }
}