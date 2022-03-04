using Microsoft.EntityFrameworkCore;
using RealEstateW.Data;
using RealEstateW.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateW.DataEF.Repositories
{
    public class UserRepository:IUserRepository
    {
        private IBaseRepository<User> _repository;

        public UserRepository(IBaseRepository<User> repository)
        {
            _repository = repository;
        }
        public async Task<int> CreateAsync(User user)
        {
            await _repository.AddAsync(user);
            return user.Id;
        }

        public async Task<User> GetAsync(string username, string password)
        {
            return await _repository.Table.SingleOrDefaultAsync(x => x.UserName == username && x.Password == password);
        }
    }
}
