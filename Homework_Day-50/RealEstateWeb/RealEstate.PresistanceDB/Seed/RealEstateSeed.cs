using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RealEstateW.Domain.POCO;
using RealEstateW.PresistanceDB.Context;
using System;
using System.Collections.Generic;

namespace RealEstateW.PresistanceDB.Seed
{
    public static class RealEstateSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using var scope = serviceProvider.CreateScope();
            var database = scope.ServiceProvider.GetRequiredService<RealEstateContext>();

            Migrate(database);
            SeedEverything(database);
        }

        private static void SeedEverything(RealEstateContext context)
        {
            var seeded = false;

            SeedProperties(context, ref seeded);

            SeedUsers(context, ref seeded);

            if (seeded)
                context.SaveChanges();
        }

        private static void Migrate(RealEstateContext context)
        {
            context.Database.Migrate();
        }

        private static void SeedProperties(RealEstateContext context, ref bool seeded)
        {
            var properties = new List<RealEstate>()
            {
                new RealEstate()
                {
                     City="Zestaphoni",
                     CadastralCode="13.20.34.245",
                     Area=15763,
                     Price=538_000

                },
                new RealEstate()
                {
                     City="Telavi",
                     CadastralCode="53.20.31.519",
                     Area=3068,
                     Price=155_000

                },
                new RealEstate()
                {
                     City="Terjola",
                     CadastralCode="33.01.36.466",
                     Area=61506,
                     Price=430_500

                },
                new RealEstate()
                {
                     City="Batumi",
                     CadastralCode="05.30.25.017",
                     Area=7138,
                     Price=1_548_946

                },
                     new RealEstate()
                {
                     City="Kutaisi",
                     CadastralCode="11.01.36.466",
                     Area=21506,
                     Price=730_500

                },
                new RealEstate()
                {
                     City="Gori",
                     CadastralCode="05.05.25.017",
                     Area=7138,
                     Price=1200000

                },
                     new RealEstate()
                {
                     City="Senaki",
                     CadastralCode="33.31.31.000",
                     Area=61506,
                     Price=430_500

                },
                new RealEstate()
                {
                     City="Kobuleti",
                     CadastralCode="60.60.00.000",
                     Area=3138,
                     Price=2_548_946

                }

            };

            foreach (var property in properties)
            {
                if (context.Properties.AnyAsync(x => x.CadastralCode == property.CadastralCode).Result) continue;

                context.Properties.Add(property);
                seeded = true;
            }
        }
        private static void SeedUsers(RealEstateContext context, ref bool seeded)
        {
            var users = new List<User>()
            {
                new User()
                {
                    UserName = "admin",
                    FirstName = "Davit",
                    LastName = "Jimshiashvili",
                    Password="1234"

                },
                new User()
                {
                    UserName = "user",
                    FirstName = "name",
                    LastName = "lastName",
                    Password="0000"

                }
            };

            foreach (var user in users)
            {
                if (context.Users.AnyAsync(x => x.UserName == user.UserName).Result) continue;

                context.Users.Add(user);
                seeded = true;
            }
        }


    }
}
