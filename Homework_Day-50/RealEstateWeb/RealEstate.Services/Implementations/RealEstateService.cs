using Mapster;
using RealEstateW.Data;
using RealEstateW.Domain.POCO;
using RealEstateW.Services.Abstractions;
using RealEstateW.Services.Exceptions;
using RealEstateW.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealEstateW.Services.Implementations
{
    public class RealEstateService : IRealEstateService
    {
        private IRealEstateRepository _repo;

        public RealEstateService(IRealEstateRepository repo)
        {
            _repo = repo;
        }

        public async Task<int> CreateAsync(RealEstateServiceModel property)
        {
            var propertyToInsert = property.Adapt<RealEstate>();

            var insertedId = await _repo.CreateAsync(propertyToInsert);

            return insertedId;
        }

        public async Task DeleteAsync(int id)
        {
            if (!await _repo.Exists(id))
                throw new ObjectNotFoundException("უძრავი ქონება არ იძებნება");

            await _repo.DeleteAsync(id);
        }

        public async Task<List<RealEstateServiceModel>> GetAllAsync()
        {
            var result = await _repo.GetAllAsync();
            return result.Adapt<List<RealEstateServiceModel>>();
        }

        public async Task<RealEstateServiceModel> GetAsync(int id)
        {
            var result = await _repo.GetAsync(id);

            if (result == null)
                throw new ObjectNotFoundException("უძრავი ქონება არ იძებნება");

            return result.Adapt<RealEstateServiceModel>();
        }
        public async Task<RealEstateServiceModel> GetByCodeAsync(string code)
        {
            var result = await _repo.GetByCodeAsync(code);

            if (result == null)
                throw new ObjectNotFoundException("უძრავი ქონება არ იძებნება");

            return result.Adapt<RealEstateServiceModel>();
        }

        public async Task<List<RealEstateServiceModel>> GetRangeAsync(double minPrice, double maxPrice)
        {
            var result = await _repo.GetRangeAsync(minPrice, maxPrice);

            if (result==null)
                throw new ObjectNotFoundException("უძრავი ქონება არ იძებნება");

            return result.Adapt<List<RealEstateServiceModel>>();
        }

        public async Task<int> UpdateAsync(RealEstateServiceModel property)
        {
            if (!await _repo.Exists(property.Id))
                throw new ObjectNotFoundException("უძრავი ქონება არ იძებნება");

            var propertyToUpdate = property.Adapt<RealEstate>();

            await _repo.UpdateAsync(propertyToUpdate);

            return property.Id;
        }


    }
}
