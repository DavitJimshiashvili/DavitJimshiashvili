using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesService.Exceptions
{
    public class MovieAlreadyExists:Exception
    {
        public string Code = "Movie Already Exsists";
        public MovieAlreadyExists(string message) : base(message) { }
    }
}
