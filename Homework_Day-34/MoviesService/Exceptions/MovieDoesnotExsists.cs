using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesService.Exceptions
{
   public class MovieDoesnotExsists:Exception
    {
        public string Code = "Movie Doesn't Exsists";
        public MovieDoesnotExsists(string message) : base(message) { }
       
    }
}
