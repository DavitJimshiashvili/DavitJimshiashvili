using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateWeb.Models.DTOs
{
    public class RealEstateDTO
    {

        public int Id { get; set; }
        public string CadastralCode { get; set; }
        public double Price { get; set; }
        public string City { get; set; }
        public int Area { get; set; }

    }
}
