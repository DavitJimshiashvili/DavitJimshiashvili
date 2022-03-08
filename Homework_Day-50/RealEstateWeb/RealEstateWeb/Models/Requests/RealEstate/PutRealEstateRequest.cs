using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateWeb.Models.Requests
{
    public class PutRealEstateRequest
    {
        public int Id { get; set; }

        [Required]
        public string CadastralCode { get; set; }
        

        public double Price { get; set; }
        

        public string City { get; set; }
        

        public int Area { get; set; }
    }
}
