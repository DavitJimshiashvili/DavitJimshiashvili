using PersonManagement.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonManagement.Services.Abstractions
{
    public interface IPersonService
    {
        Task<List<PersonServiceModel>> GetAllAsync();
        Task<PersonServiceModel> GetAsync(int id);
        Task<int> CreateAsync(PersonServiceModel person);
    }
}
