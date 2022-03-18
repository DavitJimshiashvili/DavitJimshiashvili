using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RealEstateManagement.Domain;

namespace RealEstateManagement.Data
{
    public interface IRealEstateReopsitory
    {
        Task<List<RealEstate>> GetAllAsync();
    }
}
