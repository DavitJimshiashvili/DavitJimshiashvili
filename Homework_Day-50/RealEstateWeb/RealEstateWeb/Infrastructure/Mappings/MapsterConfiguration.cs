using Mapster;
using Microsoft.Extensions.DependencyInjection;
using RealEstateW.Domain.POCO;
using RealEstateW.Services.Models;
using RealEstateWeb.Models.DTOs;
using RealEstateWeb.Models.Requests;
using RealEstateWeb.Models.Requests.Account;

namespace RealEstateWeb.Infrastructure.Mappings
{
    public static class MapsterConfiguration
    {
        public static void RegisterMaps(this IServiceCollection service)
        {

            TypeAdapterConfig<RealEstateDTO, RealEstateServiceModel>
                .NewConfig()
                .TwoWays();

            TypeAdapterConfig<RealEstateServiceModel, RealEstateDTO>
                .NewConfig()
                .TwoWays();

            TypeAdapterConfig<CreateRealEstateRequest, RealEstateServiceModel>
                .NewConfig()
                .TwoWays();

            TypeAdapterConfig<PutRealEstateRequest, RealEstateServiceModel>
                .NewConfig()
                .TwoWays();

            TypeAdapterConfig<RealEstateServiceModel, RealEstate>
                .NewConfig()
                .TwoWays();

            TypeAdapterConfig<UserServiceModel, User>
                .NewConfig()
                .TwoWays();

            TypeAdapterConfig<CreateAccountRequest, UserServiceModel>
                 .NewConfig()
                 .TwoWays();
        }

    }
}
