using RealEstateW.Data;
using RealEstateW.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RealEstateW.DataEF.Repositories
{
    public class RealEstateRepository : IRealEstateRepository
    {


        private IBaseRepository<RealEstate> _baseRepository;

        public RealEstateRepository(IBaseRepository<RealEstate> repository)
        {
            _baseRepository = repository;
        }


        public async Task<int> CreateAsync(RealEstate property)
        {
            await _baseRepository.AddAsync(property);
            return property.Id;
        }

        public async Task DeleteAsync(int id)
        {
            await _baseRepository.RemoveAsync(id);

        }

        public async Task<bool> Exists(int id)
        {
            return await _baseRepository.AnyAsync(x => x.Id == id);
        }

        public async Task<List<RealEstate>> GetAllAsync()
        {
            return await _baseRepository.GetAllAsync();
        }

        public async Task<RealEstate> GetAsync(int id)
        {

            return await _baseRepository.GetAsync(id);

        }
        public async Task<RealEstate> GetByCodeAsync(string code)
        {

            return await (from p in _baseRepository.Table
                          where p.CadastralCode == code
                          select p
                            ).SingleOrDefaultAsync();

        }

        public async Task<List<RealEstate>> GetRangeAsync(double minPrice, double maxPrice)
        {
            return await (from p in _baseRepository.Table
                          where minPrice < p.Price && p.Price < maxPrice
                          select p
                          ).ToListAsync();
        }

        public async Task UpdateAsync(RealEstate property)
        {
            await _baseRepository.UpdateAsync(property);

        }
    }

}
