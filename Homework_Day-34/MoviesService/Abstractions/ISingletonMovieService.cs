using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MoviesService.Abstractions
{
    public interface ISingletonMovieService
    {
        public Task AddMovieAsync(Movie movie);
        public Task<Movie> GetMovieAsync(int id);
        public Task<List<Movie>> GetAllMovies();
        public Task DeleteMovie(int id);

        public Task PutMovie(int id, Movie movie);

    }
}
