using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateWeb.Models.Requests
{
    public class CreateRealEstateRequest
    {
        public int Id { get; set; }

        [Required]
        public string CadastralCode { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public int Area { get; set; }

    }
}
