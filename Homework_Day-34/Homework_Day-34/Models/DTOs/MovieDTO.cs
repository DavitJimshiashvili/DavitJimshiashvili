using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_Day_34.Models.DTOs
{
    public class MovieDTO
    {
        public int ID { get; set; }
        public string Tittle { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public double IMDB { get; set; }
    }
}
