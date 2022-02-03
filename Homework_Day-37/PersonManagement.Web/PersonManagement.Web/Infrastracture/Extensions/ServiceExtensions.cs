using Microsoft.Extensions.DependencyInjection;
using PersonManagement.Services.Abstractions;
using PersonManagement.Services.Implementations;

namespace PersonManagement.Web.Infrastracture.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IPersonService, PersonService>();
        }
    }
}
