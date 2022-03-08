using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateW.Services.Models
{
    public class RealEstateServiceModel
    {
        public int Id { get; set; }
        public string CadastralCode { get; set; }
        public double Price { get; set; }
        public string City { get; set; }
        public int Area { get; set; }
    }
}
