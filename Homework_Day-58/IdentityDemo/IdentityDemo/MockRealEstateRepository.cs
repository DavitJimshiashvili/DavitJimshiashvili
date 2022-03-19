using RealEstateManagement.Data;
using RealEstateManagement.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IdentityDemo
{
    public class MockRealEstateRepository : IRealEstateReopsitory
    {
        public Task<List<RealEstate>> GetAllAsync()
        {
            return Task.FromResult(new List<RealEstate>
            {
                 new RealEstate()
                {
                     Id=1,
                     City="Zestaphoni",
                     CadastralCode="13.20.34.245",
                     Area=15763,
                     Price=538_000

                },
                new RealEstate()
                {
                     Id=2,
                     City="Telavi",
                     CadastralCode="53.20.31.519",
                     Area=3068,
                     Price=155_000

                },
                new RealEstate()
                {
                    Id=3,
                     City="Terjola",
                     CadastralCode="33.01.36.466",
                     Area=61506,
                     Price=430_500

                },
                new RealEstate()
                {
                    Id=4,
                     City="Batumi",
                     CadastralCode="05.30.25.017",
                     Area=7138,
                     Price=1_548_946

                },
                     new RealEstate()
                {
                         Id=5,
                     City="Kutaisi",
                     CadastralCode="11.01.36.466",
                     Area=21506,
                     Price=730_500

                },
                new RealEstate()
                {
                    Id=6,
                     City="Gori",
                     CadastralCode="05.05.25.017",
                     Area=7138,
                     Price=1200000

                },
                     new RealEstate()
                {
                         Id=7,
                     City="Senaki",
                     CadastralCode="33.31.31.000",
                     Area=61506,
                     Price=430_500

                },
                new RealEstate()
                {
                    Id=7,
                     City="Kobuleti",
                     CadastralCode="60.60.00.000",
                     Area=3138,
                     Price=2_548_946

                }
            });
        }
    }
}
