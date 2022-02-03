using Mapster;
using Microsoft.Extensions.DependencyInjection;
using PersonManagement.Services.Models;
using PersonManagement.Web.Models;
using PersonManagement.Web.Models.DTO;

namespace PersonManagement.Web.Infrastracture.Mappings
{
    public static class MapsterConfiguration
    {
        public static void RegisterMaps(this IServiceCollection service)
        {

            TypeAdapterConfig<PersonServiceModel, CreatePersonRequest>
                .NewConfig()
                .TwoWays();

            TypeAdapterConfig<PersonServiceModel, PersonDTO>
                .NewConfig()
                .TwoWays();



        }
    }
}
