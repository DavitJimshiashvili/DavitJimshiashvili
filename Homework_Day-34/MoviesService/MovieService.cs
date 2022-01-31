using MoviesService.Abstractions;
using MoviesService.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesService
{
    public class MovieService : ISingletonMovieService
    {
        private List<Movie> _movies = new List<Movie>()
        {
            new Movie
            {
                ID=1,
                Tittle="Tangerines",
                Genre="Drama",
                IMDB=8.3,
                ReleaseYear=2013
            },
            new Movie
            {
                ID=2,
                Tittle="Blue Mountains",
                Genre="Comedy",
                IMDB=8.9,
                ReleaseYear=1983
            },
            new Movie
            {
                ID=3,
                Tittle="Udzinarta Mze",
                Genre="Drama-Detective,",
                IMDB=8.8,
                ReleaseYear=1992
            },
            new Movie
            {
                ID=4,
                Tittle="Sherekilebi",
                Genre="Comedy-Fantasy",
                IMDB=8.9,
                ReleaseYear=1974
            }
        };


        public async Task DeleteMovie(int id)
        {
            var movie = _movies.FirstOrDefault(m => m.ID == id);
            if (movie==null)
            {
                throw new MovieDoesnotExsists("Movie doesn't Exsists");
            }
            _movies.Remove(_movies.First(m => m.ID == id));
            await Task.CompletedTask;
        }

        public async Task<List<Movie>> GetAllMovies()
        {

            return await Task.FromResult(_movies);
        }

        public async Task<Movie> GetMovieAsync(int id)
        {
            var movie = _movies.FirstOrDefault(m => m.ID ==id);
            if (movie == null)
            {
                throw new MovieDoesnotExsists($"movie with ID-{id} doesn't Exsists");
            }
            return await Task.FromResult(movie);

        }

        public  async Task AddMovieAsync(Movie movie)
        {
            var tmpMovie = _movies.FirstOrDefault(m => m.Tittle == movie.Tittle);
            if (tmpMovie!=null)
            {
                throw new MovieAlreadyExists($"Movie with Tittle-{movie.Tittle} Already Exsists");
            }
            movie.ID = _movies.Max(m => m.ID);
            movie.ID++;
            _movies.Add(movie);

            await Task.CompletedTask;
        }

        public async Task PutMovie(int id, Movie movie)
        {
            
            var concreteMovie = _movies.FirstOrDefault(m => m.ID == id);
            if (concreteMovie != null)
            {
                concreteMovie.IMDB = movie.IMDB;
                concreteMovie.ReleaseYear = movie.ReleaseYear;
                concreteMovie.Tittle = movie.Tittle;
                concreteMovie.Genre = movie.Genre;
            }
            else
            {
                throw new MovieDoesnotExsists("Movie doesn't Exsists");
            }
            await Task.CompletedTask;
        }
    }
}
