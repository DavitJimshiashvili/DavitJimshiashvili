using RealEstateW.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateW.Data
{
    public interface IUserRepository
    {
        Task<User> GetAsync(string username, string password);
        Task<int> CreateAsync(User user);
    }
}
