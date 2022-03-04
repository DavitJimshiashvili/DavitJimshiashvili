using RealEstateW.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateW.Services.Abstractions
{
    public interface IRealEstateService
    {
        Task<List<RealEstateServiceModel>> GetAllAsync();
        Task<List<RealEstateServiceModel>> GetRangeAsync(double minPrice, double maxPrice);
        Task<RealEstateServiceModel> GetAsync(int id);
        Task<RealEstateServiceModel> GetByCodeAsync(string code);
        Task<int> CreateAsync(RealEstateServiceModel property);
        Task<int> UpdateAsync(RealEstateServiceModel property);
        Task DeleteAsync(int id);
    }
}
