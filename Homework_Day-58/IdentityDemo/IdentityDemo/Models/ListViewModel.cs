using RealEstateManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityDemo.Models
{
    public class ListViewModel
    {
        public IEnumerable<RealEstate> Properties { get; set; }
    }
}
