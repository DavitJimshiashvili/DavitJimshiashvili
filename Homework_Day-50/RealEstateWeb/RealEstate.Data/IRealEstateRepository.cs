using RealEstateW.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateW.Data

{
    public interface IRealEstateRepository
    {
        Task<List<RealEstate>> GetAllAsync();
        Task<List<RealEstate>> GetRangeAsync(double minPrice, double maxPrice);
        Task<RealEstate> GetAsync(int id);
        Task<RealEstate> GetByCodeAsync(string code);
        Task<int> CreateAsync(RealEstate property);
        Task UpdateAsync(RealEstate property);
        Task DeleteAsync(int id);
        Task<bool> Exists(int id);
    }
}
