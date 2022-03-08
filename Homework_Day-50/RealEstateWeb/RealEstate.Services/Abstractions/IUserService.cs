using RealEstateW.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateW.Services.Abstractions
{
    public interface IUserService
    {
        Task<int> CreateAsync(UserServiceModel user);
        Task<string> AuthenticateAsync(string username, string password);
    }
}
