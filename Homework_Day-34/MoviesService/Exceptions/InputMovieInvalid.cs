using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesService.Exceptions
{
    public class InputMovieInvalid:Exception
    {
        public string Code = "Input is not valid";
        public InputMovieInvalid(string message) : base(message) { }
    }
}
