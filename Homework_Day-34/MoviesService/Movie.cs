using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesService
{
    public class Movie
    {
        public int ID { get; set; }
        public string Tittle { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public double IMDB { get; set; }
    }
}
